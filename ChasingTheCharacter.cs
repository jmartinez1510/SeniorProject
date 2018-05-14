using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingTheCharacter : MonoBehaviour {

	public float playerTargetDistance;
	public float enemyLookDistance;
	public float attackDistance;
	public float enemymovement;
	public float damping;
	public Transform playerTarget;
	Rigidbody SomeRigidbody;
	Renderer SomeRender;

	// Use this for initialization
	void Start () {
		//SomeRender = GetComponent<Renderer>();
		//SomeRigidbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update() {
		if (touchWall == 1)
			playerTarget.transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime);
	}

	/*void FixedUpdate () {
		playerTargetDistance = Vector3.Distance (playerTarget.position, transform.position);
		if (playerTargetDistance < enemyLookDistance) {
			SomeRender.material.color = Color.yellow;
			lookAtPlayer ();
			print ("Look at Player");
		}
		if (playerTargetDistance < attackDistance) {
			SomeRender.material.color = Color.red; 
			chase ();
			print ("chase");
		} else {
			SomeRender.material.color = Color.blue;
		}

		//if(playerTarget.transform
		
	}*/

	public static int touchWall = 0;

	void OnCollisionEnter() {
		touchWall = 1;
		//playerTarget.transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime);
		//transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime);
	}

	void movement() {
	}

	/*void lookAtPlayer() {
		Quaternion rotation = Quaternion.LookRotation (playerTarget.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void chase() {
		//SomeRigidbody.AddForce (transform.forward * enemymovement);
		transform.Translate (new Vector3 (-speed, 0, 0) * Time.deltaTime);
	}*/
}
	 