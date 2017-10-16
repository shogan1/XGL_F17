using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {


	// The idea here is that the instance variable stores the only instance of this AudioManager.
	// the GameObject this AudioManager is attached to should be a prefab, and in every scene in your game.
	// When the game starts, if there's no instance of the AudioManager class, then it is created.
	// Otherwise, this script will destroy itself and the attached game object.


	public static AudioManager instance;
	AudioSource audioSource;
	public AudioClip clip;



	void Start () {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			// Create the game-wide (global) instance.
			instance = this;
			// When you call this function, Unity won't destroy the object on a scene change.
			DontDestroyOnLoad (gameObject);
			// This is specific to this particular use of a singleton instance: this will play audio once and it will
			// loop throughout the game
			audioSource = GetComponent <AudioSource> ();
			audioSource.clip = clip;
			audioSource.loop = true;
			audioSource.Play ();

			// Note that now, in other scripts, you can use AudioManager.instance to modify the audio manager.
			// You could add functions to this class to change the song, etc.
			// Note that for complicated audio stuff you are better off learning how to use something like WWise.
		}
	}
}
