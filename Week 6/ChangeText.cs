using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour {
	TMP_Text TMP_text_object;

	// Use this for initialization
	void Start () {
		TMP_text_object = GetComponent<TMP_Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			TMP_text_object.text += " Banana ";
		}
	}
}
