using UnityEngine;
using System.Collections;

public class loadLevelSelect : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		//if player enters the collider, load level select
		if (other.gameObject.tag == "Player") {

			Application.LoadLevel (0);
		}
	}
}
