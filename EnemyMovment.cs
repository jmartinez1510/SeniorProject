using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour {

	public Transform Player;
	public float speed;
	//public float MoveSpeed;
	//public float MaxDist;
	public float MinDist;
	public Transform currentAIlocation;
	private Animator myAnimator;
	public static bool NotNearPlayer = true;
	public bool FacingLeft;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator>();
		FacingLeft = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (NotNearPlayer == true) {
			myAnimator.ResetTrigger ("idle");
			myAnimator.SetTrigger ("walk");
		}

		if (NotNearPlayer == false) {
			myAnimator.ResetTrigger ("walk");
			myAnimator.SetTrigger ("idle");
		}

		if (NotNearPlayer == true) {
			if (Player.position.x == currentAIlocation.position.x)
				transform.Translate (new Vector3 (0, 0, 0) * Time.deltaTime);
			if (Player.position.x <= currentAIlocation.position.x) {
				//FacingLeft = true;
				/*if(Player.position.x <= currentAIlocation.position.x && FacingLeft != true)
					Flip ();*/
				transform.Translate (new Vector3 (speed, 0, 0) * Time.deltaTime);
			}
			if (Player.position.x >= currentAIlocation.position.x) {
				//FacingLeft = false;
				/*if (Player.position.x >= currentAIlocation.position.x && FacingLeft != false)
					Flip ();*/
				transform.Translate (new Vector3 (-speed, 0, 0) * Time.deltaTime);
			}

		if (Player.position.z == currentAIlocation.position.z)
				transform.Translate (new Vector3 (0, 0, 0) * Time.deltaTime);
			if (Player.position.z <= currentAIlocation.position.z)
				transform.Translate (new Vector3 (0, 0, speed) * Time.deltaTime);
			if (Player.position.z >= currentAIlocation.position.z)
				transform.Translate (new Vector3 (0, 0, -speed) * Time.deltaTime);
		}

		if(Player.position.x <= currentAIlocation.position.x && FacingLeft != true)
			Flip ();
		if (Player.position.x >= currentAIlocation.position.x && FacingLeft != false)
			Flip ();
	}

	void Flip() {
		FacingLeft = !FacingLeft;
		Vector3 thisScale = transform.localScale;
		thisScale.x *= -1;
		transform.localScale = thisScale;
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag ("Player")) {
			NotNearPlayer = false;
		}
	}

	void OnCollisionExit(Collision other) {
		//if (other.gameObject.CompareTag ("Player")) {
			NotNearPlayer = true;
		//}
	}

}


/*


		transform.LookAt(Player);

		if(Vector3.Distance(transform.position,Player.position) >= MinDist){

			transform.position += transform.forward*MoveSpeed*Time.deltaTime;



			//if(Vector3.Distance(transform.position,Player.position) <= MaxDist) {
				//Here Call any function U want Like Shoot at here or something
			//}

		}
		
	transform.LookAt(Player);
	transform.Translate (Vector3.forward * 1 * MoveSpeed * Time.deltaTime);

	void Start () {
		myAnimator = GetComponent<Animator> ();
		target = GameObject.FindWithTag ("Player").transform;
	}
	void Update () {
		int xDir = 0;
		int zDir = 0;

		if (Mathf.Abs (target.position.x - transform.position.x) < float.Epsilon)
			zDir = target.position.z > transform.position.z ? 1 : -1;
		else
			xDir = target.position.x > transform.position.x ? 1 : -1;
	}
*/