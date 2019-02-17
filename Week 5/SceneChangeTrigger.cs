using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// When overlapping the player, changes the scene.




// You have to type this *outside of the class*, to get access to Scene functions in Unity.
using UnityEngine.SceneManagement;


public class SceneChangeTrigger : MonoBehaviour {

	public static string storedDestinationName = "";

	public string destinationScene;
	public string destinationName;


    // Use this function in the "Start" function of some GameObject that you want to move. E.g., the player.
    public static void moveSomethingToStoredDestination(Transform thingToMove) {
        if (storedDestinationName == "") return;
		thingToMove.position = GameObject.Find(storedDestinationName).transform.position;
	}

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            // Note: this won't work unless the destination scene has been added to the Build
            // inside of Build Settings.
            storedDestinationName = destinationName;
            SceneManager.LoadScene(destinationScene);

        }
    }

    void OnTriggerEnter2D(Collider2D c) {
		if (c.CompareTag ("Player")) {
			// Note: this won't work unless the destination scene has been added to the Build
			// inside of Build Settings.
			storedDestinationName = destinationName;
			SceneManager.LoadScene (destinationScene);

		}
	}
}
