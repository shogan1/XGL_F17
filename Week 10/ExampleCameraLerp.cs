using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCameraLerp : MonoBehaviour {

	public Transform destination;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			transform.position = Vector3.Lerp (transform.position, destination.position, Time.deltaTime * 3);

			transform.eulerAngles = Vector3.Lerp (transform.eulerAngles, destination.eulerAngles, Time.deltaTime * 3);
		}
	}
}
