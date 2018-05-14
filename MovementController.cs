using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
	public float speed;
	public float speedmod;
	public float morespeedmod;
	Jump jump = new Jump();

	private Animator myAnimator;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update() {



		if (Input.GetKey(KeyCode.UpArrow)) {
			//speed = 10;
			myAnimator.ResetTrigger("idle");
			transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
			myAnimator.SetTrigger("walk");
		}
		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			myAnimator.ResetTrigger("walk");
			myAnimator.SetTrigger("idle");
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			//speed = -10;
			myAnimator.ResetTrigger("idle");
			transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
			myAnimator.SetTrigger("walk");
		}
		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			myAnimator.ResetTrigger("walk");
			myAnimator.SetTrigger("idle");
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			//speed = 10;
			myAnimator.ResetTrigger("idle");
			transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
			myAnimator.SetTrigger("walk");
		}
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			myAnimator.ResetTrigger("walk");
			myAnimator.SetTrigger("idle");
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			//speed = -10;
			myAnimator.ResetTrigger("idle");
			transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
			myAnimator.SetTrigger("walk");
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
			myAnimator.ResetTrigger("walk");
			myAnimator.SetTrigger("idle");
		}
		if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
		{
			//speed = -10;
			//if (jump.onGround == true) {
			transform.Translate(new Vector3(speed * speedmod, 0, speed * speedmod) * Time.deltaTime);
			/*}*/ /*else {
			transform.Translate (new Vector3 (speed * speedmod * morespeedmod, 0, speed * speedmod * morespeedmod) * Time.deltaTime);
		}*/
	}
	if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
	{
		//speed = -10;
		transform.Translate(new Vector3(speed * speedmod, 0, -speed * speedmod) * Time.deltaTime);
	}
	if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
	{
		//speed = -10;
		transform.Translate(new Vector3(-speed * speedmod, 0, -speed * speedmod) * Time.deltaTime);
	}
	if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
	{
		//speed = -10;
		transform.Translate(new Vector3(-speed * speedmod, 0, speed * speedmod) * Time.deltaTime);
	}

        //Controller
	//left
	if (InputManager.MainHorizontal() < 0)
	{
		myAnimator.ResetTrigger("idle");
		transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
		myAnimator.SetTrigger("walk");
	}
	else if (InputManager.MainHorizontal() == 0)
	{
		myAnimator.ResetTrigger("walk");
		myAnimator.SetTrigger("idle");
	}
	//right
	if (InputManager.MainHorizontal() > 0)
	{
		myAnimator.ResetTrigger("idle");
		transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
		myAnimator.SetTrigger("walk");
	}
	else if (InputManager.MainHorizontal() == 0)
	{
		myAnimator.ResetTrigger("walk");
		myAnimator.SetTrigger("idle");
	}
	//up
	if (InputManager.MainVertical() > 0)
	{
		myAnimator.ResetTrigger("idle");
		transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
		myAnimator.SetTrigger("walk");
	}
	else if (InputManager.MainVertical() == 0)
	{
		myAnimator.ResetTrigger("walk");
		myAnimator.SetTrigger("idle");
	}
	//down
	if (InputManager.MainVertical() < 0)
	{
		myAnimator.ResetTrigger("idle");
		transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
		myAnimator.SetTrigger("walk");
	}
	else if (InputManager.MainVertical() == 0)
	{
		myAnimator.ResetTrigger("walk");
		myAnimator.SetTrigger("idle");
	}

}
}
