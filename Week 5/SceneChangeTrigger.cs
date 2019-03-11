using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// You have to type this *outside of the class*, to get access to Scene functions in Unity.
using UnityEngine.SceneManagement;

// This script does this: When overlapping the player, changes the scene.





public class SceneChangeTrigger : MonoBehaviour {

	public static string storedDestinationName = "";

	public string destinationScene;
	public string destinationName;


    // Use this function in the "Start" function of some GameObject that you want to move. E.g., the player.
    public static void moveSomethingToStoredDestination(Transform thingToMove) {
        if (storedDestinationName == "") return;

        thingToMove.position = GameObject.Find(storedDestinationName).transform.position;
	}

    void OnTriggerEnter2D(Collider2D c) {
		if (c.tag == "Player") {
		    storedDestinationName = destinationName;
			SceneManager.LoadScene (destinationScene);
		}
	}


    void OnTriggerEnter(Collider c) {
        if (c.tag == "Player") {
            storedDestinationName = destinationName;
            SceneManager.LoadScene(destinationScene);
        }
    }
}
