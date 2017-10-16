using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimpleDialogueDisplayObject : MonoBehaviour {

	public string textToShow;
	bool useCharByCharDisplay = true;

	SimpleDialogueDisplayer displayer;



	void Start () {
		displayer = GameObject.Find ("text_dialogue").GetComponent <SimpleDialogueDisplayer> ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {

			if (useCharByCharDisplay) {
				displayer.startDialogue (textToShow);
			} else {
				displayer.textToDisplay = textToShow;
			}

		}
	}


	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			if (useCharByCharDisplay) {
				displayer.stopDialogue ();	
			} else {
				displayer.textToDisplay = "";
			}
		}
	}
}
