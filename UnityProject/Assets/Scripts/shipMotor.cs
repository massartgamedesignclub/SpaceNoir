using UnityEngine;
using System.Collections;

public class shipMotor : MonoBehaviour {

	//The horizontal input
	float h;
	//The Vertical Input
	float v;
	//The speed modifier for movement
	float speed = 10.0f;
	
	// Update is called once per frame
	void Update () {
		//Get the horizontal or vertical input
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

	}

	void FixedUpdate () {
		//Move the player based on inputs
		transform.position += transform.right * h * speed * Time.deltaTime;
		transform.position += transform.forward * v * speed * Time.deltaTime;
	}
}
