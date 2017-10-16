using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlanePositionLerp : MonoBehaviour {


	Vector3 initialPosition;
	public float maximumYOffset = 2f;

	float timer = 0;
	float timerMAX = 2f;

	// Use this for initialization
	void Start () {
		initialPosition = transform.position;
	}

	int moveState = 0;

	// Update is called once per frame
	void Update () {

		if (moveState == 0) {
			timer += Time.deltaTime;

			Vector3 newPosition = initialPosition;

			float smoothedTime = Mathf.SmoothStep (0,1,timer/timerMAX);

			float YOffset = Mathf.Lerp (0, maximumYOffset, smoothedTime);
			newPosition.y += YOffset;
			transform.position = newPosition;

			if (timer > timerMAX) {
				timer = 0;
				moveState = 1;
			}
		} else if (moveState == 1) {

			timer += Time.deltaTime;


			Vector3 newPosition = initialPosition;
			float YOffset = Mathf.Lerp (maximumYOffset, 0, timer / timerMAX);
			newPosition.y += YOffset;
			transform.position = newPosition;

			if (timer > timerMAX) {
				timer = 0;
				moveState = 0;
			}
		}

	}
}
