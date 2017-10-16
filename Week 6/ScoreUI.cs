using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour {
	TMP_Text TMP_text_object;

	public static int score = 0;

	// Use this for initialization
	void Start () {
		TMP_text_object = GetComponent<TMP_Text> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			//score += 1;
		}

		TMP_text_object.text = "Score: " + score.ToString ();


		if (score > 3) {
			TMP_text_object.text = "Congratulations. Congratulations. Congratulations.";
		}

		// To String() takes 4 and gives you back the string "4" 

	}
}
