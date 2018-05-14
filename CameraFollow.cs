//Created this instead of making Main Camera a child of character(Player)

using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	private Vector3 holdPos;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}

	//Camera becomes focused on one scene. Simulates beat em up battle
	void ChangeCamera () {
		//Debug.Log ("CameraFollow, changecamera");
		if (CameraTrigger.TrigOn == 1)
			player = GameObject.Find ("cameraTrig");
	}

	//Shifts camera back to character. Simulates deleting all enemies by pressing M
	void ChangeCameraPress() {
		if (Input.GetKey (KeyCode.M)) {
			//CameraTrigger.TrigOn = 0;
			CameraTrigger.Recenter = 1;
			if(CameraTrigger.SnapOn == 1)
				player = GameObject.Find ("character");
			//Delete gameObject just so it can't be triggered again
			/*if (CameraTrigger.SnapOn == 1) {
				Debug.Log ("Did we snap?");
				Destroy (GameObject.Find ("cameraTrig"));
			}*/
			//Once deleted, return possible adjustment to camera to allow another battle camera
			CameraTrigger.KeepOn = 1;
			CameraTrigger.wallTrigg = 0;
			//CameraTrigger.wall1.gameObject.SetActive (false);
			//CameraTrigger.wall2.gameObject.SetActive (false);
			//WallsForCam.wallTrig = 0;

		}
	}

	void SnapFunc() {
		if (CameraTrigger.SnapOn == 1) {
			//Debug.Log ("Did we snap?");
			CameraTrigger.TrigOn = 0;
			CameraTrigger.SnapOn = 0;
			//Debug.Log (CameraTrigger.SnapOn);
			player = GameObject.Find ("character");
			Destroy (GameObject.Find ("cameraTrig"));

		}
	}
	
	// Update is called once per frame
	// LateUpdate is called after everything else


	void LateUpdate () {
		ChangeCamera ();
		ChangeCameraPress ();
		SnapFunc ();
		//This followed the player in terms of x
		//transform.position = player.transform.position + offset;

		//This follows the player in terms of x since y is fixed to 1 and z is fixed to -7
		transform.position = new Vector3 (player.transform.position.x + offset.x, 1, -7);
	}
}
