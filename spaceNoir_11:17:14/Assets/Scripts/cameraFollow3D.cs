using UnityEngine;
using System.Collections;

public class cameraFollow3D : MonoBehaviour {
	//player reference
	GameObject player;

	void Start () {
		//find the player and assign it to variable
		player = GameObject.FindGameObjectWithTag("target");
	}

	void Update () {
		//Set the camera's position equal to the camera targets x and z position
		transform.position = new Vector3 (player.transform.position.x, gameObject.transform.position.y, player.transform.position.z); 
	}
}
