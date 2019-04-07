using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoopingTextDisplayer : MonoBehaviour
{
    // This script expects there to be a UI Image and TMP Text object in your UI

    public string TMP_Text_Object_Name = "Dialogue";
    public string DialogueBoxName = "DialogueBox";

    [TextArea(3, 10)]
    public string[] textsToDisplay = new string[] { "Add the text you want to show here. (Edit in the Inspector)" };

    int textIndex = 0;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            GameObject.Find(DialogueBoxName).GetComponent<UnityEngine.UI.Image>().enabled = true;
            GameObject.Find(TMP_Text_Object_Name).GetComponent<TMP_Text>().text = textsToDisplay[textIndex];
            textIndex++;
            if (textIndex == textsToDisplay.Length) textIndex = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag == "Player") {
            GameObject.Find(DialogueBoxName).GetComponent<UnityEngine.UI.Image>().enabled = false;
            // "" is also called 'the empty string'
            GameObject.Find(TMP_Text_Object_Name).GetComponent<TMP_Text>().text = "";
        }

    }

}
