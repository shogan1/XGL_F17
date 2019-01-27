using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Xml;


public class DataLoader : MonoBehaviour {
	public static DataLoader instance;

	public List<LevelData> levelDatas;
	public List<DialogData> dialogDatas;
	Dictionary<string,int> dialogState;

	public bool autoSet = true;
	public string autoSetTo1_1 = "";
	public string autoSetTo1_2 = "";
	void Awake () {
		if (instance != null ) {
			Destroy(gameObject);
		} else {
			instance = this;
		}

		DontDestroyOnLoad(this);



		DialogHolder dialogHolder = DialogHolder.Load ("Scripts/xml/Dialogue Data");
		dialogDatas = dialogHolder.DialogDatas;

// iterate through the dialogDatas to make sure everything works fine
		foreach (DialogData d in dialogDatas) {
			//print (d.Name); 
			if (d.Name == "DEFAULT") {
				for (int i = 0; i < d.lines.Count; i++) {
				//	print (d.lines [i].Dialog); 
				//	print (d.lines [i].PictureID); 
				}
			}
		}
		
	}


}
