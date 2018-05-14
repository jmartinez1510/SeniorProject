using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

	public static int TrigOn;
	public GameObject player;
	Vector3 holdPos;
	public static int KeepOn = 1;
	public static int Recenter = 0;
	public static int SnapOn = 0;
	public static int OneWay = 0;
	public GameObject wall1;
	public GameObject wall2;
	public static int wallTrigg = 0;
	public static int trigCnt = 0;
	//Collider collideThing;


	//Object that has this code corresponds to objects intersecting it. All gameobjects currently, not just character
	//Have to fix since AI enemies could touch the trigger
	void OnTriggerEnter(Collider col) {

		//this if statement because trying to create non jagged camera readjustment to background
		if(KeepOn == 1) {
		//if (col.gameObject.name == "cameraTrig") {
		//Debug.Log ("Hit");
			TrigOn = 1;
			holdPos = player.transform.position;
			transform.position = holdPos;

			//Prevent camera from returning to player when player re-enters trigger
			KeepOn = 0;

			//WallsForCam.wallTrig = 1;

			//wallTrigg = 1;
			//This is a TEMPORARY FIX, current logic somehow makes wallTrigg = 1, 
			//creating walls again if character doesn't run out of area in split second. 
			//This trigCnt to make it impossible, but this doesn't help game at all
			//CURRENT LOGIC on why this happens:
			//CameraTrigger object follows player, then player prehaps hit the object, thus hitting this function
			//and triggering the walls to be active with wallTrigg = 1
			if(trigCnt == 0)
				wallTrigg = 1;
			trigCnt++;

		//player = new GameObject ("cameraTrig");
		//}
		}
	}

	void WallCamera() {
		if (wallTrigg == 1) {
			wall1.gameObject.SetActive (true);
			wall2.gameObject.SetActive (true);
		}
		if (wallTrigg == 0) {
			wall1.gameObject.SetActive (false);
			wall2.gameObject.SetActive (false);
			//Destroy(GameObject.Find("Wall1"));
			//Destroy (GameObject.Find ("Wall2"));
		}
	}

	void CameraRefocus () {
		if (Recenter == 1) {
			Vector3 RefocusPos = transform.position;
			Vector3 CharPos = player.transform.position;
			if (RefocusPos.x > CharPos.x) {
				OneWay = 1;
				//RefocusPos.x = RefocusPos.x - .05f;
				//transform.position = RefocusPos;
			}
			if (RefocusPos.x < CharPos.x) {
				OneWay = 2;
			}
			/*if (RefocusPos.x > CharPos.x + 1 && RefocusPos.x < CharPos.x - 1) {
				SnapOn = 1;
				Recenter = 0;
			}*/
		}
	}

	void OneWayL () {
		Vector3 RefocusPos = transform.position;
		Vector3 CharPos = player.transform.position;
		if (OneWay == 1) {
			RefocusPos.x = RefocusPos.x - .03f;
			transform.position = RefocusPos;
			if (RefocusPos.x > CharPos.x - .05f && RefocusPos.x < CharPos.x + .05f) {
				//Debug.Log ("Left here");
				SnapOn = 1;
				Recenter = 0;
				OneWay = 0;
			}
		}
		if (OneWay == 2) {
			RefocusPos.x = RefocusPos.x + .03f;
			transform.position = RefocusPos;
			if (RefocusPos.x > CharPos.x - .05f && RefocusPos.x < CharPos.x + .05f) {
				//Debug.Log ("Right here");
				SnapOn = 1;
				Recenter = 0;
				OneWay = 0;
			}
		}
	}

	// Use this for initialization
	void Start () {
		//collideThing = GetComponent<BoxCollider> ("Wall1");
	}


	
	// Update is called once per frame
	void Update () {
		CameraRefocus ();
		OneWayL ();
		WallCamera ();
		//Debug.Log (OneWay);
		//Debug.Log (SnapOn);

		//This was on before turned off on March 7
		//Debug.Log(wallTrigg);
	}
}
