using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour {

	// Keeps track of which keys you have.
	// A KeyPickup script will edit this array.
	bool[] keyState;
    // set this to some number!
    public int keysNeeded = 0;

	// Use this for initialization
	void Start () {

        keyState = new bool[keysNeeded];

		// Arrays are indexed from 0, meaning the first item in the array has an index of 0
		//keyState [0] = false;
		//keyState [1] = false;
		// This line would give an error, because it's trying to get 3rd item
		//keyState [2] = false;

		// Arrays can't be resized once created, if you need to resize an array, use a list instead


	}
	
    public void setKey(int index) {
        keyState[index] = true;
    }

	// Update is called once per frame
	void Update () {

		// By default, set this to true, which will disable this door...
		bool unlockDoor = true;


		// For loop has three parts: iterator initialization, condition, end of loop code
		for (int i = 0; i < keyState.Length; i++) {
			// ...However, if we need the i'th key and don't have it, prevent the 
			// door from being unlocked.
			if (!keyState [i]) {
				unlockDoor = false;
			}
		}

		if (unlockDoor) {
			gameObject.SetActive (false);
		}
	}
}
