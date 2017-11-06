using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// You can attach this to a singleton instance,
// Or add it to a prefab and include that prefab in every scene.
public class InputManager : MonoBehaviour {

	public bool rightHeld = false;
	public bool leftHeld = false;
	public bool rightJustPressed = false;
	public bool leftJustPressed = false;

	KeyCode kc_right = KeyCode.D;
	KeyCode kc_left = KeyCode.A;
	void Update () {

		rightHeld = Input.GetKey (kc_right);
		leftHeld = Input.GetKey (kc_left);
		rightJustPressed = Input.GetKeyDown (kc_right);
		leftJustPressed = Input.GetKeyDown (kc_left);

	}
}
