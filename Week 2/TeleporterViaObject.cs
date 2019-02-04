using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterViaObject : MonoBehaviour {

    public GameObject destinationTeleporter;


	// OnTriggerStay2D, OnTriggerExit2D
	void OnTriggerEnter2D(Collider2D playerCollider) {
		Vector3 newPlayerPosition = new Vector3 ();
		newPlayerPosition = destinationTeleporter.transform.position;
		playerCollider.transform.position = newPlayerPosition;
	}

	void OnTriggerStay2D(Collider2D playerCollider) {
		
	}

}
