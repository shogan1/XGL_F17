using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyPickup : MonoBehaviour {


	// Change the key color and ID as needed.
	public bool isARedKey = true;
	// This ID corresponds to the keyState array of a LockedDoor script.
	public int keyID = 0;
	// Drag this from the inspector
	public LockedDoor door;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider c) {
		//print (1);
		if (c.CompareTag ("Player")) {
			door.redKeyState [keyID] = true;
			gameObject.SetActive (false);
		}
	}
}
