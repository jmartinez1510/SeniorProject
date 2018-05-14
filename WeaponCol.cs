using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCol : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		
		if (col.tag == "Enemy") {
			//Debug.Log ("EnemyHit!!!");
			float damage = 40;
			col.SendMessageUpwards ("TakeDamage", damage);
			WeaponScript.WeaponGoing = 0;
			this.gameObject.SetActive (false);
			//Destroy (this);
		}

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
