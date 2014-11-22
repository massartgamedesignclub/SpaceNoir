using UnityEngine;
using System.Collections;

public class loadTestLevel : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		//if the player enters the collider, load the Test level
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel (1);
		}
	}

}
