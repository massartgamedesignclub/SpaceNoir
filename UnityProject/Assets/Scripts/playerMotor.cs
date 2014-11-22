using UnityEngine;
using System.Collections;

public class playerMotor : MonoBehaviour {

	//The horizontal input
	float h;
	//The gameObject to check for the ground
	private Transform groundCheck;
	//The location of the spawn point
	private GameObject spawn;
	//whether the player is touching the ground
	bool grounded = false;

	//sped of player on ground
	float speed = 100.0f;
	//speed of plyaer in air
	float airSpeed = 10.0f;
	//upward force on player when jumping
	float jumpForce = 500f;

	void Awake () {
		//Find groundcheck and the spawn point and assign it to the variable
		groundCheck = transform.Find ("groundCheck");
		spawn = GameObject.FindGameObjectWithTag ("Respawn");
	}
	
	void Start () {
		//start the player at the spawn point
		transform.position = spawn.transform.position;
	}

	void Update () {
		//Set h equal to the current horizontal input from -1 to 1
		h = Input.GetAxis ("Horizontal");
		//draw a line from the player to the groundCheck, if it hits a collider on the ground layer, sets to true
		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("ground"));

		if (grounded) {
			gameObject.rigidbody2D.drag = 10;
		} else {
			gameObject.rigidbody2D.drag = 0;
		}


	}

	void FixedUpdate () {


		//modify the position based on speed over time
			if (grounded) {
						//if on ground, move player at speed
						rigidbody2D.AddForce (transform.right * speed * h);
						//transform.position += transform.right * h * speed * Time.deltaTime;
				} else {
						//if not on ground, move player at airSpeed
						rigidbody2D.AddForce (transform.right * airSpeed * h);
						//transform.position += transform.right * h * airSpeed * Time.deltaTime;
				}


			

		if (grounded && Input.GetButtonDown ("Jump")) {

			//when jump button pressed, add upward force
				rigidbody2D.AddForce (transform.up * jumpForce);

			//another method modifying position directly, too rigid right now
				//transform.position += transform.up * jumpForce;
		}


	}
}
