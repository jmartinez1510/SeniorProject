using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPick : MonoBehaviour {

	public static int foodCanGet = 0;
	public static int healMe = 0;
	public static float heal = 40;
	void OnTriggerEnter(Collider col) {
		foodCanGet = 1;
	}

	void OnTriggerStay(Collider col) {
		if (healMe == 1) {
			if (col.tag == "Player") {
				col.SendMessageUpwards ("HealDamage", heal);
				this.gameObject.SetActive (false);
				Destroy (this);
			}
		}
	}

	void OnTriggerExit(Collider col) {
		foodCanGet = 0;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (foodCanGet == 1) {
            if (Input.GetKey(KeyCode.J) || Input.GetButtonDown("RB_Button"))
            {
                healMe = 1;
            }
            /*if (foodCanGet == 1)
            {
                foodCanGet = 0;
            }*/


        }
        //added this so it can reset upon food pick up so audio doesnt keep playing
        //picking up food. uncomment if another solution isnt found.
       
	}
}
