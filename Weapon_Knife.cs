using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Knife : MonoBehaviour {


	public static int weaponCanGet = 0;
	public static int certainWeapon = 0;
	GameObject closest;
	public GameObject player;

	Collider c;
	//public Transform text;

	//when player collides with pickup, weaponCanGet is turned on
	void OnTriggerEnter(Collider col) {
		weaponCanGet = 1;
	}
	//Same as above, except turned off
	void OnTriggerExit(Collider col) {
		weaponCanGet = 0;
	}

	// Use this for initialization
	void Start () {
		//text = GameObject.Find ("PlayerHealth");
		//text = transform.Find("background/PlayerHealth/Ratio");
	}

	// Update is called once per frame
	void Update () {
		//text = transform.Find("background/PlayerHealth/Ratio");
		if (weaponCanGet == 1) {
			if (Input.GetKey (KeyCode.J)|| Input.GetButtonDown("RB_Button")) {
				//Healthbar health = new Healthbar();
				//string heal = "20";
				//health.HealDamage (heal);
				//float damage = 20;
				//c.SendMessageUpwards ("TakeDamage", damage);
				//text.GetComponent<UnityEngine.UI.Text>().text = heal;
				//float heal = 20;
				//SendMessageUpwards ("HealDamage", heal);

				GameObject[] gos;
				gos = GameObject.FindGameObjectsWithTag("Weapon");

				float distance = Mathf.Infinity;
				Vector3 position = player.transform.position;
				//Vector3 position = transform.position;
				foreach (GameObject go in gos) {
					Vector3 diff = go.transform.position - position;
					float curDistance = diff.sqrMagnitude;
					if (curDistance < distance) {
						closest = go;
						distance = curDistance;
					}
				}
				if (closest.gameObject.name == "PickUp_W_Stick" && WeaponScript.WeaponOn == 0) {
					WeaponScript.WeaponOn = 1;
					closest.gameObject.SetActive (false);
					Destroy(closest.gameObject);
				}
				if (closest.gameObject.name == "PickUp_W_Knife" && WeaponScript.WeaponOn == 0) {
					WeaponScript.WeaponOn = 2;
					closest.gameObject.SetActive (false);
					Destroy(closest.gameObject);
				}

				//This code below to turn off pick up when picked up
				//this.gameObject.SetActive (false);
				//Destroy(closest.gameObject);
				/*if (gameObject.tag == "Weapon_Knife") {
					WeaponScript.WeaponOn = 2;
					this.gameObject.SetActive (false);
				}

				//This code below to turn off pick up when picked up
				//this.gameObject.SetActive (false);
				Destroy(this.gameObject);*/
			}
		}
	}
}
