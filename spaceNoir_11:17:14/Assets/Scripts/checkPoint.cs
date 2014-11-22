using UnityEngine;
using System.Collections;

public class checkPoint : MonoBehaviour {
	GameObject spawn;
	// Use this for initialization
	void Awake () {
		spawn = GameObject.FindGameObjectWithTag ("Respawn");
	}
	
	void OnTriggerEnter2D (Collider2D other) {
		//if player enters the collider, load level select
		if (other.gameObject.tag == "Player") {
			spawn.gameObject.transform.position = this.gameObject.transform.position;
			Destroy(this.gameObject);
		}
	}
}
