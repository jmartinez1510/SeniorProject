using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTE TO SELF: THIS FILE NAME "Weapon_Stick" should only be temporary since this is supposed to be the universal file for all weapon pickups
//NOW Weapon_Knife might be the universal scripting!!!!!!!!!!!

public class Weapon_Stick : MonoBehaviour {


	public static int weaponCanGet = 0;
	public static int certainWeapon = 0;

	//when player collides with pickup, weaponCanGet is turned on
	void OnTriggerEnter(Collider col) {
		weaponCanGet = 1;
		if (col.gameObject.tag == "Weapon_Stick") {
			certainWeapon = 1;

		}
		if (col.gameObject.tag == "Weapon_Knife") {
			certainWeapon = 2;
		}
		//Debug.Log (certainWeapon);
	}
	//Same as above, except turned off
	void OnTriggerExit(Collider col) {
		weaponCanGet = 0;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Is this here");
		//With player within range of pickup, can pick up weapon with key command

		/*if (weaponCanGet == 1) {
			if (Input.GetKey (KeyCode.J)) {
				//if (gameObject.name == "PickUp_W_Stick") {
				if(gameObject.tag == "Weapon_Stick") {
				//if(certainWeapon == 1) {
					WeaponScript.WeaponOn = 1;
					//this.gameObject.SetActive (false);
				}
				//if(certainWeapon == 2) {
				if (gameObject.tag == "Weapon_Knife") {
					//WeaponScript.WeaponOn = 2;
					//this.gameObject.SetActive (false);
				}
					
				//This code below to turn off pick up when picked up
				this.gameObject.SetActive (false);
			}
		}*/
	}
}
