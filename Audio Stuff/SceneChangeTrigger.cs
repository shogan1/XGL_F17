using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// When overlapping the player, changes the scene.
// Challenge: How would you get this script to warp you to a particular point 
//	in the next scene? 
//
// 				Hint: You will need to create a GameObject in the destination scene, and this Game OBject
//					  will represent the position your SceneChangeTrigger will send the player to
// 				Hint: You will need to store the name of that destination GameObject in a way that lets you
// 					  use the name between two scenes (Hint: static variables let you store stuff between scenes)
//				Hint: You need to add a script to the player that will check if the player should warp to a destination.
//						(Where should this warping code go? Start() or Update()?)
//			



// You have to type this *outside of the class*, to get access to Scene functions in Unity.
using UnityEngine.SceneManagement;


public class SceneChangeTrigger : MonoBehaviour {

	public string destinationScene;


	void OnTriggerEnter(Collider c) {
		if (c.CompareTag ("Player")) {
			// Note: this won't work unless the destination scene has been added to the Build
			// inside of Build Settings.
			SceneManager.LoadScene (destinationScene);

		}
	}
}
