using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	//player reference
	private GameObject player;
	
	void Awake () {
		//find the player and assign it to variable
		player = GameObject.FindGameObjectWithTag("target");
	}
	
	// Update is called once per frame
	void Update () {
		//Set the camera's position equal to the camera targets x and y position
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, gameObject.transform.position.z); 
	}
}
