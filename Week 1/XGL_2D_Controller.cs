using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XGL_2D_Controller : MonoBehaviour {

	// Use this for initialization

	public float maxVelocity = 8f;

	Rigidbody2D rb;
	Vector3 newVelocity;
	Vector3 newCameraPosition;

	Camera mainCamera;
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
		newVelocity = new Vector3 ();
		newCameraPosition = new Vector3 ();
		mainCamera = GameObject.Find ("Main Camera").GetComponent <Camera> ();
	}

	// Update is called once per frame
	void Update () {

		newVelocity.Set (0, 0, 0);

		if (Input.GetKey (KeyCode.UpArrow)) {
			newVelocity.y = maxVelocity;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			newVelocity.y = -maxVelocity;
		}


		if (Input.GetKey (KeyCode.RightArrow)) {
			newVelocity.x = maxVelocity;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			newVelocity.x = -maxVelocity;
		}

		rb.velocity = newVelocity;

		newCameraPosition = this.transform.position;
		newCameraPosition.z = -10; 
		mainCamera.transform.position = newCameraPosition;

	}
}
