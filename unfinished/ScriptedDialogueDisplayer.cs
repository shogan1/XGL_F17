using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptedDialogueDisplayer : MonoBehaviour {

    [TextArea(6, 10)]
    public string RunOnStart;

    [TextArea(20, 25)]
    public string RunOnInteract;

	// Use this for initialization
	void Start () {
        if (flagBox == null) flagBox = new Dictionary<string, int>();
        isParsingStart = true;
        UpdateParse();
        UpdateParse();
        OnInteractMode = 0;
        isParsingStart = false;
       // displayer = GameObject.Find("text_dialogue").GetComponent<SimpleDialogueDisplayer>();
	}

    bool isParsingStart = false;
    bool isParsingInteract = false;

    bool pauseForSay;
    bool pauseForChoice;


    int OnInteractMode = 0;
    string[] lines;
    int InteractParseCurLine = 0;
    bool skipToEndIf = false;
    bool skipToNextConditional = false;
    bool insideIf = false;
    public static Dictionary<string, int> flagBox;

    // Update is called once per frame
    /*
     * if SCENE is 1
     * say SCENE2 // "I've talked to you!"
     * elseif
     * say SCENE1 // " Will you be my friend?"
     * set SCENE1 to 1
     * choice SCENECHOICE continue LABELNAME // "
     * say  SCENEAFTERCHOICE
     * endif
     * stop
     * */

    int getFlag(string key) {
        if (flagBox.ContainsKey(key) == false) flagBox.Add(key, 0);
        return flagBox[key];
    }
    void setFlag(string key, int value) {
        if (flagBox.ContainsKey(key) == false) flagBox.Add(key, 0);
        flagBox[key] = value;
    }

    void Update() {

        if (isParsingInteract) {
            UpdateParse();
        }
    }

    // Called from DialogueBox when some piece of dialogue is done
    public void unpauseSay() {
        pauseForSay = false;
    }
    public void unpauseChoice() {
        pauseForChoice = false;
    }

    void UpdateParse() {
        if (OnInteractMode == 0) {
            lines = RunOnInteract.Split(new char[]{'\n'});
            if (isParsingStart) lines = RunOnStart.Split(new char[] { '\n' });
            OnInteractMode = 1;
            InteractParseCurLine = -1;
        } else if (OnInteractMode == 1){

            if (pauseForSay) {
                return;
            }
            if (pauseForChoice) {
                return;
            }

            while (InteractParseCurLine < lines.Length - 1) {
                InteractParseCurLine++;
                string line = lines[InteractParseCurLine].Trim();
                string[] parts = line.Split(new char[] { ' ' });
                string command = parts[0];

                // Hit end of the if or elif block, skip to endif command
                if (insideIf && (command == "elif" || command == "else")) {
                    insideIf = false;
                    skipToEndIf = true;
                }

                if (skipToEndIf) {
                    if (command != "endif") {
                        continue;
                    }                    
                }

                if (command == "if" || command == "elif" || command == "andif") {
                    // e.g. if ... andif ..., if the first if is false, fall through to next conditional
                    if (command == "andif" && skipToNextConditional) {
                        continue;
                    }
                    skipToNextConditional = false;
                    string scene = parts[1];
                    int checkVal = safeIntParse(parts[3]);
                    if (checkVal != getFlag(scene)) {
                        skipToNextConditional = true;
                        continue;
                    }
                    insideIf = true;
                    continue;
                }  else if (command == "else") {
                    skipToNextConditional = false;
                    continue;
                } else if (command == "endif") {
                    skipToNextConditional = false;
                    continue;
                } else if (command == "stop") {
                    OnInteractMode = 2;
                    break;
                }

                if (skipToNextConditional) continue;
                   
                if (command == "set") {
                    setFlag(parts[1],safeIntParse(parts[3]));
                } else if (command == "choice") {
                    pauseForChoice = true;
                    // Start choice command in DialogueBox
                    return;
                } else if (command == "say") {
                    pauseForSay = true;
                    // Start say command in dialoguebox
                    return;
                } else if (command == "print") {
                    print(line);
                } else if (command == "move") {
                    GameObject moveToThisObject = GameObject.Find(parts[2]);
                    transform.position = moveToThisObject.transform.position;
                }
            }
            OnInteractMode = 2;
        } else if (OnInteractMode == 2) {
            // End
            print("Done");
            OnInteractMode = 3;
        }
    }

    int safeIntParse(string s) {
        return int.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
    }

    bool insideTrigger = false;
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isParsingInteract && Input.GetKey(KeyCode.Space)) {
                isParsingInteract = true;
                insideTrigger = true;
            }
         //   displayer.setMode(false);
         //   displayer.setDialogue(textToShow);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {
            insideTrigger = false;
        }
    }
}
