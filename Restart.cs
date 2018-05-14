using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public GameObject player;
	public GameObject healthBar;
	private Vector3 startLocation;
	public static string check;

	// Use this for initialization
	void Start () {
		startLocation = player.transform.position;

	}

	// Update is called once per frame
	void Update () {
		check = healthBar.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.Q) || check == "0%"/*Healthbar.deadPlayer == 1*/|| Input.GetButtonDown("Select_Button")) {
			//Debug.Log ("AAAAAAAAAAAAAAAAAAAAAAAAAAA");
			CameraTrigger.TrigOn = 0;
			CameraTrigger.KeepOn = 1;
			CameraTrigger.Recenter = 0;
			CameraTrigger.SnapOn = 0;
			CameraTrigger.OneWay = 0;
			CameraTrigger.wallTrigg = 0;
			CameraTrigger.trigCnt = 0;
			HealthPick.foodCanGet = 0;
			HealthPick.healMe = 0;
			player.transform.position = startLocation;
			EnemyMovment.NotNearPlayer = true;
			//Healthbar.deadPlayer = 0;
			SceneManager.LoadScene ("pracScene", LoadSceneMode.Single);
		}
	}
}
