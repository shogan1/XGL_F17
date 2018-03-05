using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Attached to some trigger - the "textToShow" will appear on the screen when you overlap this trigger
// You need to have a TextMeshPro gameobject in your scene's UI with the name "text_dialogue". That
//  TextMeshPro object needs to have the Displayer script attached as well
public class SimpleDialogueDisplayObject : MonoBehaviour {

    [TextArea(5,10)]
    public string textToShow;
    public bool useCharByCharDisplay = false;

    SimpleDialogueDisplayer displayer;




    void Start () {
        displayer = GameObject.Find ("text_dialogue").GetComponent <SimpleDialogueDisplayer> ();
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag ("Player")) {

            if (useCharByCharDisplay) {
                displayer.setMode(true);
                displayer.startDialogue (textToShow);
            } else {
                displayer.setMode(false);
                displayer.setDialogue(textToShow);
            }

        }
    }


    void OnTriggerExit(Collider other) {
        if (other.CompareTag ("Player")) {
            if (useCharByCharDisplay) {
                displayer.stopDialogue ();  
            } else {
                displayer.setDialogue("");
            }
        }
    }
}