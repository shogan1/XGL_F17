using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3rdPerson : MonoBehaviour {

	Camera cam;
	public Vector3 cameraOffset;
	// Use this for initialization
	void Start () {
		cam = GameObject.Find ("Main Camera").GetComponent<Camera> ();
	}

	float targetYRotation = 0f;

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			targetYRotation -= 90f * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			targetYRotation += 90f * Time.deltaTime;
		}


		// Keep rotation values between 0 and 360f
		if (targetYRotation > 360f) {
			targetYRotation -= 360f;
		} else if (targetYRotation < 0f) {
			targetYRotation += 360f;
		}

		// Multiply this by a vector to rotate that vector by yRotation degrees about the world's y Axis
		Quaternion qRot = Quaternion.Euler (0, targetYRotation, 0);

		// Move the camera to the defualt distance from the target
		cam.transform.position = transform.position + (qRot*cameraOffset);
		cam.transform.LookAt (transform.position);

		// Movement code

		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 movementVec = cam.transform.forward;
			movementVec.y = 0;
			movementVec = Vector3.Normalize (movementVec);
			movementVec *= 3f;
			Rigidbody rb = GetComponent<Rigidbody> ();
			rb.velocity = movementVec;
		}
		
	}
}
