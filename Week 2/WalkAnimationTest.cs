using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimationTest : MonoBehaviour {


	// This script will change the state of the attached game object's animation controller

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		// You can add other states inside the Animator window.
		if (Input.GetKey (KeyCode.DownArrow)) {
			animator.Play("Walk");
		} else {
			animator.Play ("Idle");	
		}

	}
}
