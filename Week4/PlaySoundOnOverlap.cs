using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
public class PlaySoundOnOverlap : MonoBehaviour {

	AudioSource _audioSource; // the in-game "speaker"
	public AudioClip soundEffect; // the audio clip file, set through the inspector

	// Use this for initialization
	void Start () {
		
		_audioSource = GetComponent<AudioSource> ();
		_audioSource.clip = soundEffect;

	}

	void OnTriggerEnter(Collider c) {
		if (c.CompareTag ("Player")) {
			_audioSource.Play ();
		}
	}


}
