using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyPickup : MonoBehaviour {


	// This ID corresponds to the keyState array of a LockedDoor script.
	public int keyID = 0;
	// Drag this from the inspector
	public LockedDoor door;

	
	void OnTriggerEnter(Collider c) {
		if (c.CompareTag ("Player")) {
            
            door.setKey(keyID);
			gameObject.SetActive (false);

		}
	}
}
