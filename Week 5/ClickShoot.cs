using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// S17 XGL wk10
// 

// attach this to anything

// Uses a raycast to turn an object red and also apply a force to it.
public class ClickShoot : MonoBehaviour {

	void Start () {
		
	}
	
	void FixedUpdate () {

		// Check if mouse was left-clicked
		if (Input.GetMouseButtonDown (0)) {

			// Create a ray with origin at the camera and going *through* the mous eposition
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			// Ray should go for 100 units
			// Layer mask means that only stuff on layer 0 will be hit.
			if (Physics.Raycast (ray, out hit, 100f, 1 << 0)) {
				
				// If it hits something, we can access that game object through our RaycastHit:
				// hit.collider.gameObject

				// Change the color
				MeshRenderer mr = hit.collider.gameObject.GetComponent <MeshRenderer> ();
				if (mr != null) {
					mr.material.color = Color.red;
				}

				// Only apply a force if the gameObject HAS a rigidbody
				Rigidbody rb = hit.collider.gameObject.GetComponent <Rigidbody> ();
				if (rb != null) {
					rb.AddForce (600f, 600f, 200f);
				}

			}


			// This is if you want only the object this script is attached to, to be interactable
			if (Physics.Raycast (ray, out hit, 100f)) {
				if (hit.collider.gameObject.name == gameObject.name) {
					// Do something...
				}
			}
		}
	}
}
