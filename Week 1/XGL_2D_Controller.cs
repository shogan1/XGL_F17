using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class XGL_2D_Controller : MonoBehaviour {

	public float maxVelocity = 8f;

	Rigidbody2D rb;
	Vector3 newVelocity;
	Vector3 newCameraPosition;

	Camera mainCamera;


    [Header("Deadzone Info")]
    // Imagine a box centered around the center of the camera. This box's width and height are
    // measured in units. 
    // The width of the box is the camera's orthographic size multiplied by deadZoneX.
    // Likewise for height and deadZoneY.
    // If the player steps outside of the box, the camera begins to follow the player.
    // The higher that 'cameraFollowFactor' is, the faster the camera follows the player.
    public bool hasDeadZone = true;
    [Range(0,1)]
    public float deadZoneX = 0.4f;
    [Range(0, 1)]
    public float deadZoneY = 0.4f;
    [Range(1f,15f)]
    public float cameraFollowFactor = 6f;


    Animator animator; 
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
		newVelocity = new Vector3 ();
		newCameraPosition = new Vector3 ();
		mainCamera = GameObject.Find ("Main Camera").GetComponent <Camera> ();

        SceneChangeTrigger.moveSomethingToStoredDestination(transform);
        mainCamera.transform.position = transform.position;
        if (hasDeadZone) {
            mainCamera.orthographic = true;
        }
    }
    void Update () {

        newVelocity.Set (0, 0, 0);

		if (Input.GetKey (KeyCode.UpArrow)) {
			newVelocity.y = maxVelocity;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			newVelocity.y = -maxVelocity;
		}


		if (Input.GetKey (KeyCode.RightArrow)) {
			newVelocity.x = maxVelocity;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			newVelocity.x = -maxVelocity;
		}

		rb.velocity = newVelocity;

        if (hasDeadZone) {
            float orthoSize = mainCamera.orthographicSize;
            Vector2 playerOffsetFromCamera = transform.position - mainCamera.transform.position;

            newCameraPosition = mainCamera.transform.position;
            float percentXFromCenter = playerOffsetFromCamera.x / orthoSize;
            if (percentXFromCenter > deadZoneX) {
                // too far right
                newCameraPosition.x = transform.position.x - deadZoneX * orthoSize;
            } else if (percentXFromCenter < -deadZoneX) {
                newCameraPosition.x = transform.position.x + deadZoneX * orthoSize;
            }

            float percentYFromCenter = playerOffsetFromCamera.y / orthoSize;
            if (percentYFromCenter > deadZoneY) {
                // too far up
                newCameraPosition.y = transform.position.y - deadZoneY * orthoSize;
            } else if (percentYFromCenter < -deadZoneY) {
                newCameraPosition.y = transform.position.y + deadZoneY * orthoSize;
            }
            Vector2 finalCamPos = Vector2.Lerp(mainCamera.transform.position, newCameraPosition, cameraFollowFactor*Time.deltaTime);
            newCameraPosition = finalCamPos;
        } else {
            newCameraPosition = this.transform.position;
        }
		newCameraPosition.z = -10; 
		mainCamera.transform.position = newCameraPosition;

	}

}
