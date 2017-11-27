using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreener : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Screen.fullScreen = !Screen.fullScreen;
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			Resolution[] resolutions = Screen.resolutions;
			int r = Random.Range (0, resolutions.Length - 1);
			// If done in fullscreen, the game will render at this resolution but scale
			// to fit the screen (so like, 320x240 would look awful) 
			Screen.SetResolution (resolutions[r].width,resolutions[r].height,Screen.fullScreen);
		}
	}
}
