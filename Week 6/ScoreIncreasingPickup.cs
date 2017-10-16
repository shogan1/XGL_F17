using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script that will increase the score of a ScoreUI object, when this script's trigger overlaps the player.
public class ScoreIncreasingPickup : MonoBehaviour {

	public ScoreUI scoreUI;
	public int pickupID; // this will be from 0 to 3.. or whatever. used to index into the pickupState array.

	static bool[] pickupState;
	static int numberOfPickups = 4;

	void Start () {

		if (pickupState == null) {
			pickupState = new bool[numberOfPickups];
			// so the array contains only 'false'.
		}

		if (pickupState[pickupID] == true) {
			gameObject.SetActive (false);
		}

		// There's two ways to get references to objects:
		// Using GameObject.Find() (useful if you know the object's name will never change)
		//scoreUI = GameObject.Find ("text_score").GetComponent <ScoreUI>();

		// Or assigning through the inspector
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			ScoreUI.score++;
			pickupState [pickupID] = true;
			gameObject.SetActive (false);
		}
	}
}
