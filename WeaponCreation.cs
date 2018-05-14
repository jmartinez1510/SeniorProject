//This file is for creating weapons to be dropped by enemies or destroying environments.
//Current idea is to create gameObject, addcomponent to apply appropriate script, and add sprite

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCreation : MonoBehaviour {


	public Sprite knifeSprite;

	// Use this for initialization
	void Start () {

		//Loads sprite from Resources folder. Folder named Resources because Unity has built in functions for that name
		knifeSprite = Resources.Load<Sprite> ("weapon_Knife2");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.H)) {
			//Create new gameObject, give it name, tag, script, position(hardcoded), sprite renderer, box collider, 
			//dimensions of box collider, and positioning of box collider
			GameObject newWeapon = new GameObject ();
			newWeapon.gameObject.name = "PickUp_W_Knife";
			//newWeapon.gameObject.tag = "Weapon_Knife";
			newWeapon.gameObject.tag = "Weapon";
			newWeapon.gameObject.AddComponent <Weapon_Knife>();
			Vector3 nWPos = newWeapon.gameObject.transform.position;
			nWPos.x = 2.984f;
			nWPos.y = 0.77f;
			nWPos.z = -5.7f;
			newWeapon.gameObject.transform.position = nWPos;
			newWeapon.AddComponent<SpriteRenderer> ();
			newWeapon.GetComponent<SpriteRenderer> ().sprite = knifeSprite;
			newWeapon.GetComponent<SpriteRenderer> ().color = new Color (0f, 1f, 0f, 1f);

			newWeapon.AddComponent<BoxCollider> ();
			newWeapon.GetComponent<BoxCollider> ().isTrigger = true;
			Vector3 boxSize = newWeapon.GetComponent<BoxCollider> ().size;
			//newWeapon.GetComponent<BoxCollider> ().size.x = 0.19f;
			//newWeapon.GetComponent<BoxCollider> ().size.y = 0.26f;
			//newWeapon.GetComponent<BoxCollider> ().size.x = 0.11f;
			boxSize.x = 0.19f;
			boxSize.y = 0.26f;
			boxSize.z = 0.11f;
			newWeapon.GetComponent<BoxCollider> ().size = boxSize;
			Vector3 boxCenter = newWeapon.GetComponent<BoxCollider> ().center;
			boxCenter.y = -0.18f;
			newWeapon.GetComponent<BoxCollider> ().center = boxCenter;
			GameObject foundPlayer = GameObject.FindGameObjectWithTag ("Player");
			newWeapon.GetComponent<Weapon_Knife> ().player = foundPlayer;
			//The next two codes didn't work, keeping in case figured out
			//SpriteRenderer sRen = (SpriteRenderer)GetComponent<Renderer>();
			//sRen.sprite = knifeSprite;

		}
		
	}
}
