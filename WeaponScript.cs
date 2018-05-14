using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {

	//WeaponOn number indicates what weapon used currently. 0 is bare hands, 1 is stick, 2, is knife, etc...
	public static int WeaponOn = 0;
	public static int WeaponGoing = 0;
	public GameObject weapon1;
	public GameObject weapon2;
	public GameObject player;
	public Sprite knifeSprite;
	public Sprite stickSprite;
	Vector3 knifePos;
	//public float knifeRot;


	// Use this for initialization
	void Start () {
		//knifeRot = 0;
		weapon1.SetActive (false);
		weapon2.SetActive (false);
		knifeSprite = Resources.Load<Sprite> ("weapon_Knife2");
		stickSprite = Resources.Load<Sprite> ("weapon_Stick");
		//GameObject newWeapon = new GameObject ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKey (KeyCode.N))||(Input.GetButtonDown("LB_Button"))) {
			WeaponThrown();
			WeaponOn = 0;
		}
		if (WeaponGoing == 1) {
			WeaponGo ();
		}
		WCheck ();
		//Debug.Log (WeaponOn);
		if (WeaponOn == 0) {
			weapon1.SetActive (false);
			weapon2.SetActive (false);
		}
		if (WeaponOn == 1) {
			weapon1.SetActive (true);
			weapon2.SetActive (false);
		}
		if (WeaponOn == 2) {
			weapon1.SetActive (false);
			weapon2.SetActive (true);
		}
	}

	void WeaponThrown() {
		if (WeaponOn == 1) {
			knifePos = player.transform.position;
			GameObject newWeapon = new GameObject ();
			newWeapon.gameObject.tag = "ThrowItem";
			knifePos.y = 1.0f;
			newWeapon.gameObject.transform.position = knifePos;
			//
			newWeapon.AddComponent<BoxCollider> ();
			newWeapon.gameObject.AddComponent <WeaponCol>();
			Vector3 boxSize = newWeapon.GetComponent<BoxCollider> ().size;
			boxSize.x = 0.19f;
			boxSize.y = 0.26f;
			boxSize.z = 0.11f;
			newWeapon.GetComponent<BoxCollider> ().isTrigger = true;
			newWeapon.GetComponent<BoxCollider> ().size = boxSize;
			Vector3 boxCenter = newWeapon.GetComponent<BoxCollider> ().center;
			boxCenter.y = -0.18f;
			newWeapon.GetComponent<BoxCollider> ().center = boxCenter;
			//
			newWeapon.AddComponent<SpriteRenderer> ();
			newWeapon.GetComponent<SpriteRenderer> ().sprite = stickSprite;
			//newWeapon.GetComponent<SpriteRenderer> ().color = new Color (0f, 1f, 0f, 1f);
			WeaponOn = 0;
			WeaponGoing = 1;
		}
		if (WeaponOn == 2) {
			knifePos = player.transform.position;
			GameObject newWeapon = new GameObject ();
			newWeapon.gameObject.tag = "ThrowItem";
			knifePos.y = 1.0f;
			newWeapon.gameObject.transform.position = knifePos;
			newWeapon.AddComponent<SpriteRenderer> ();
			//
			newWeapon.AddComponent<BoxCollider> ();
			newWeapon.gameObject.AddComponent <WeaponCol>();
			Vector3 boxSize = newWeapon.GetComponent<BoxCollider> ().size;
			boxSize.x = 0.19f;
			boxSize.y = 0.26f;
			boxSize.z = 0.11f;
			newWeapon.GetComponent<BoxCollider> ().isTrigger = true;
			newWeapon.GetComponent<BoxCollider> ().size = boxSize;
			Vector3 boxCenter = newWeapon.GetComponent<BoxCollider> ().center;
			boxCenter.y = -0.18f;
			newWeapon.GetComponent<BoxCollider> ().center = boxCenter;
			//
			newWeapon.GetComponent<SpriteRenderer> ().sprite = knifeSprite;
			newWeapon.GetComponent<SpriteRenderer> ().color = new Color (0f, 1f, 0f, 1f);
			WeaponOn = 0;
			WeaponGoing = 1;
		}
		WeaponOn = 0;
		//Need to make a code depending on character facing orientation, then make weapon projectile from that facing

	}
	void WeaponGo() {
		GameObject curr = GameObject.FindGameObjectWithTag ("ThrowItem");
		knifePos.x += .07f;
		//knifeRot = 50f;
		//curr.transform.Rotate(Vector3.left, knifeRot * Time.deltaTime);
		//curr.transform.rotation = Quaternion.Euler (knifeRot, curr.transform.rotation.y, curr.transform.rotation.z);
		curr.transform.position = knifePos;
	}

	void WCheck() {
		if (WeaponOn == 0) {
			weapon1.SetActive (false);
			weapon2.SetActive (false);
		}
	}


}
