//This file contains functions on a barrel.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour {
	public GameObject player;
	Vector3 BarrelPos;
	public static int BarrelLeftMove = 0, BarrelRightMove = 0;
	public float BarrelSpeed;
	Vector3 playerPos;
	/*void BarrelMove() {
		if (BarrelHit == 1) {
			BarrelPos.x += 0.1f;
			transform.position = BarrelPos;
		}
	}*/


	void OnCollisionEnter(Collision col) {
		//First detects if object colliding is indeed a player
		if (col.gameObject.tag == "Player") {
			//If player is on the right of barrel, triggers left movement
			if(playerPos.x > BarrelPos.x && BarrelRightMove != 1)
				BarrelLeftMove = 1;
			//If player is on the left of the barrel, triggers right movement instead
			if (playerPos.x < BarrelPos.x && BarrelLeftMove != 1)
				BarrelRightMove = 1;
		}
	}

	// Use this for initialization
	void Start () {
		//BarrelPos = transform.position;
		//this.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		//BarrelPos and playerPos keeps track of barrel position on map and player position on map
		BarrelPos = transform.position;
		playerPos = player.transform.position;

		//Debug.Log(BarrelHit, gameObject);
		//Debug.Log (BarrelHit);

		//With barrel moving right, x position incremented positive and placed back into transform.position for Unity
		if (BarrelRightMove == 1) {
			BarrelPos.x += BarrelSpeed;
			transform.position = BarrelPos;
		}
		//Same as above, but for left
		if (BarrelLeftMove == 1) {
			BarrelPos.x -= BarrelSpeed;
			transform.position = BarrelPos;
		}
	}
}
