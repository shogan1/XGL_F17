using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad3rdPerson : MonoBehaviour {

    Rigidbody rb;
    Camera _cam;
    public Vector3 offset;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        _cam = Camera.main;

        offset = new Vector3(0,3f,-3f);
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(0,0,50f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -50f);
        }

        Vector3 newCameraPosition = transform.position + offset;
        _cam.transform.position = newCameraPosition;
        _cam.transform.LookAt(transform);


        Vector3 camForward = _cam.transform.forward;
        camForward.y = 0;
        camForward.Normalize();


        if (Input.GetKey(KeyCode.W))
        {
            Vector3 newVelocity = camForward * 10f;
            rb.velocity = newVelocity;
        }

        if (Input.GetKey(KeyCode.S))
        {

            Vector3 newVelocity = camForward * 10f * -1;
            rb.velocity = newVelocity;
        }



        Vector3 camRight = _cam.transform.right;
        camRight.y = 0;
        camRight.Normalize();

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newVelocity = camRight * 10f;
            rb.velocity = newVelocity;
        }

        if (Input.GetKey(KeyCode.A))
        {

            Vector3 newVelocity = camRight * 10f * -1;
            rb.velocity = newVelocity;
        }


	}
}
