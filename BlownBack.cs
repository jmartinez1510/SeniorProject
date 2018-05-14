using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlownBack : MonoBehaviour {


	//Type for script so we can put script into variable script.
	public MonoBehaviour script;
	public GameObject player;
	public Sprite Bback;
	public bool fallBack = false;
	public bool fallBack2 = false;
	Vector3 lastKnown;
	public static int count = 0;

	// Use this for initialization
	void Start () {
		script = GetComponent<Movement> ();
		Bback = Resources.Load<Sprite> ("blownBack4");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.P) && count == 0) {
			player.GetComponent<Animator> ().enabled = false;
			player.GetComponent<SpriteRenderer> ().sprite = Bback;
			script.enabled = false;
			fallBack = true;
			fallBack2 = true;
			count = 0;
		}
		if (fallBack == true) {
			GetComponent<Rigidbody>().velocity = Vector2.up * 4;
			fallBack = false;
		}
		//Configuring time for this with count
		if (fallBack2 == true) {
			lastKnown = player.transform.position;
			lastKnown.x -= .03f;
			player.transform.position = lastKnown;
			count += 1;
			if (Jump.onGround == true && count > 20) {
				fallBack2 = false;
				player.GetComponent<Animator> ().enabled = true;
				script.enabled = true;
				count = 0;
			}
		}


		//Turns off script, Movement in this case, and can turn on again.
		if (Input.GetKey (KeyCode.L)) {
			script.enabled = false;
		}
		if (Input.GetKey (KeyCode.O)) {
			script.enabled = true;
			player.GetComponent<Animator> ().enabled = true;
		}
	}
}
