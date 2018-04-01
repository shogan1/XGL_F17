using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

// This is attached to a textmeshpro UI text which is named 'text_dialogue'
// You do not need to edit this script's textToDisplay property - the DisplayObject script does that
public class SimpleDialogueDisplayer : MonoBehaviour
{

    string textToDisplay = "";
    TMP_Text uiTextElement;
    public Image dialogueBackgroundImage;
    // Use this for initialization
    void Start()
    {
        uiTextElement = GetComponent<TMP_Text>();
    }


    // Debug stuff (change these to change behavior of script)
    bool useSimpleDisplay = true;
    bool useCharByCharDisplay = false;

    // You can use timers to make something only happen every so often
    float timerShowChar = 0;

    [Tooltip("How long it takes to show one character in this dialogue box.")]
    public float timerShowCharMAX = 0.02f;

    public float periodPauseTime = 0.4f;

    int characterDisplayState = 0;

    int mostRecentDisplayedCharacterIndex = 0;


    public void setMode(bool charbychar = false) {
        if (charbychar){
            useSimpleDisplay = false;
            useCharByCharDisplay = true;
        } else {
            useSimpleDisplay = true;
            useCharByCharDisplay = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (useSimpleDisplay)
        {
            uiTextElement.text = textToDisplay;
        }
        else if (useCharByCharDisplay)
        {
            // This coding pattern is called 'finite state machine'

            // In this state, the script waits until a SimpleDialogueDisplayObject script
            // calls the "startDialogue" function, which will transition the state to 1.
            if (characterDisplayState == 0)
            {
                uiTextElement.text = "";

                // In this state, the displayed text will appear character by character.
            }
            else if (characterDisplayState == 1)
            {

                timerShowChar += Time.deltaTime;

                if (timerShowChar > timerShowCharMAX)
                {
                    timerShowChar = 0;
                    // e.g., if textToDisplay is "Apple", then textToDisplay[0] is "A", etc.


                    if (mostRecentDisplayedCharacterIndex < textToDisplay.Length)
                    {

                        if (textToDisplay[mostRecentDisplayedCharacterIndex].ToString() == ".")
                        {
                            timerShowChar = -periodPauseTime;
                        }

                        uiTextElement.text += textToDisplay[mostRecentDisplayedCharacterIndex];
                        mostRecentDisplayedCharacterIndex += 1;
                    }
                }

            }

        }
    }

    public void setDialogue(string textt) {
        textToDisplay = textt;
        dialogueBackgroundImage.enabled = true;
        if (textt == "")
        {
            dialogueBackgroundImage.enabled = false;
        }
    } 
    public void startDialogue(string _textToDisplay)
    {
        characterDisplayState = 1; // Change the state to zero so text starts to display.
        textToDisplay = _textToDisplay;
        mostRecentDisplayedCharacterIndex = 0;
        dialogueBackgroundImage.enabled = true;
    }

    // This function will be called when the player leaves the trigger of a SimpleDialogueDisplayObject.
    public void stopDialogue()
    {
        characterDisplayState = 0;
        textToDisplay = "";
        dialogueBackgroundImage.enabled = false;
    }

}