using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteEnemy : MonoBehaviour {

	public GameObject enemy;
	public GameObject healthBar;
	public GameObject enemy1;
	public GameObject healthBar1;
	public GameObject enemy2;
	public GameObject healthBar2;
	public GameObject enemy3;
	public GameObject healthBar3;
	public GameObject enemy4;
	public GameObject healthBar4;
	public GameObject enemy5;
	public GameObject healthBar5;
	public GameObject enemy6;
	public GameObject healthBar6;
	public GameObject enemy7;
	public GameObject healthBar7;
	public GameObject enemy8;
	public GameObject healthBar8;
	public GameObject enemy9;
	public GameObject healthBar9;
	public GameObject enemy10;
	public GameObject healthBar10;
	//private Vector3 startLocation;
	public static string check;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		check = healthBar.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar1.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy1);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar2.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy2);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar3.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy3);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar4.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy4);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar5.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy5);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar6.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy6);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar7.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy7);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar8.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy8);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar9.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy9);
			EnemyMovment.NotNearPlayer = true;
		}
		check = healthBar.GetComponent<UnityEngine.UI.Text> ().text.ToString();
		if(Input.GetKey(KeyCode.O) || check == "0%"/*Healthbar.deadPlayer == 1*/) {
			Destroy (enemy10);
			EnemyMovment.NotNearPlayer = true;
		}
		
	}
}
