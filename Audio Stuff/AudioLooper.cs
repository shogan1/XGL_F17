using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLooper : MonoBehaviour {

	public bool loopBasedOnSeconds = true;
	public float loopStartPointInPCMSamples = 0;
	public float loopStartPointInSeconds = 0;

	AudioClip clip;
	AudioSource source;
	// Use this for initialization
	void Start () {
		source = GetComponent <AudioSource> ();
		source.loop = false;
		source.playOnAwake = false;

		source.Play ();


	}
	
	// Update is called once per frame
	void Update () {
		if (loopBasedOnSeconds) {
			if (loopStartPointInSeconds > 0) {
				if (source.isPlaying == false) {
					source.Play ();
					source.time = loopStartPointInSeconds;
				}
			}
		} else {
			if (loopStartPointInPCMSamples > 0) {
				if (source.isPlaying == false) {
					source.Play ();
					source.timeSamples = (int) loopStartPointInPCMSamples;
				}
			}
		}

	}
}
