using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour {
	

	// Keeps track of which keys you have.
	// A KeyPickup script will edit this array.
	public bool[] redKeyState;
	// Edit these in the editor, set each entry/item/element/value/whatevr of the array to true if you need that 
	// corresponding key.
	public bool[] requiredRedKeys;

	public static int score = 0;


	// Use this for initialization
	void Start () {


		// This is how you initialize an array with entries in it.
		int[] numbers = new int[]{ 1, 4, 6 };

		// There's only up to 2 red keys associated with any one door.
		// This is how you initialize an array with a certain number of items
		redKeyState = new bool[4];


		// Arrays are indexed from 0, meaning the first item in the array has an index of 0
		redKeyState [0] = false;
		redKeyState [1] = false;
		// This line would give an error, because it's trying to get 3rd item
		//redKeyState [2] = false;

		// Arrays can't be resized once created, if you need to resize an array, use a list instead



	}
	
	// Update is called once per frame
	void Update () {

		// By default, set this to true, which will disable this door...
		bool unlockDoor = true;


		// For loop has three parts: iterator initialization, condition, end of loop code
		for (int i = 0; i < redKeyState.Length; i++) {

			// ...However, if we need the i'th key and don't have it, prevent the 
			// door from being unlocked.
			if (requiredRedKeys[i] && !redKeyState[i]) {
				unlockDoor = false;
			}
		}

		if (unlockDoor) {
			gameObject.SetActive (false);
		}
	}
}
