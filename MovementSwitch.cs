using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSwitch : MonoBehaviour {

	public MonoBehaviour script1;
	public MonoBehaviour script2;

	// Use this for initialization
	void Start () {
		script1 = GetComponent<Movement> ();
		script2 = GetComponent<MovementController> ();
		script2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			Debug.Log ("WAAA");
			script1.enabled = false;
			script2.enabled = true;
		}
		if (Input.GetKey (KeyCode.E)) {
			script1.enabled = true;
			script2.enabled = false;
		}
	}
}
