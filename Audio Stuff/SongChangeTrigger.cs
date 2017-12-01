using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongChangeTrigger : MonoBehaviour {

	BoxCollider bc;
	public AudioSource audioSourceToFadeIn;
	public AudioSource audioSourceToFadeOut;
	public float transitionTime = 2f;
	// Use this for initialization
	void Start () {

		if (audioSourceToFadeIn == null || audioSourceToFadeOut == null) {
			Debug.LogWarning ("You need to connect audio sources to this script through the inspector!");
			enabled = false;
			return;
		}
		bc = GetComponent <BoxCollider> ();
		if (bc == null) {
			Debug.LogWarning ("You need to add a Box Collider to this script and set 'is trigger' to true!");
			enabled = false;
			return;
			
		}
				bc.isTrigger = true;

		GameObject go = GameObject.Find ("FPSController");
		if (go != null) {
			go.tag = "Player";
		}
	}

	int mode = 0;
	float t = 0;
	
	// Update is called once per frame
	void Update () {
			
		if (mode == 0) {
			
		} else if (mode == 1) {
			if (audioSourceToFadeIn.volume == 1) {
				mode = 0;
				t = 0;
				return;
			}
			
			t += Time.deltaTime;
			audioSourceToFadeIn.volume = Mathf.Lerp (0, 1, t / transitionTime);
			audioSourceToFadeOut.volume = Mathf.Lerp (1,0, t / transitionTime);

			if (t >= transitionTime) {
				t = 0;
				mode = 0;
			}

		}
	}

	void OnTriggerEnter(Collider c) {
		if (c.CompareTag ("Player") == true) {
			mode = 1;
		}
	}
}
