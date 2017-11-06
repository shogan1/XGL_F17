using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a basic 2D platformer controller. Note you need to use Rigidbody2D, not the regular Rigidbody.
public class BasicPlatformerSean : MonoBehaviour {

	public float horizontalSpeed = 3f;
	public float jumpSpeed = 5f;
	Rigidbody2D rigidbody2d;
	BoxCollider2D boxcollider2d;
	Animator animator;

	bool onGround = true;

	// Use this for initialization
	void Start () {
		rigidbody2d = GetComponent <Rigidbody2D> ();
		animator = GetComponent <Animator> ();
		boxcollider2d = GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {


		// Check our inputs.

		bool rightHeldDown = Input.GetKey (KeyCode.RightArrow);
		bool leftHeldDown = Input.GetKey (KeyCode.LeftArrow);
		bool jumpJustPressed = Input.GetKeyDown (KeyCode.Space); // Different from GetKey.

		// Movement logic. 
		Vector2 nextVelocity = rigidbody2d.velocity; // to change the velocity it needs to be stored in a Vector2



		// Question: What happens if you hold right AND left? If this behavior is problematic, how would you fix it?
		if (rightHeldDown) {
			nextVelocity.x = horizontalSpeed;
		} else if (leftHeldDown) {
			nextVelocity.x = -horizontalSpeed;
			// Question: why do you need this else statement? What would happen if it was removed?
		} else {
			nextVelocity.x = 0;
		}

		if (onGround) {
			if (jumpJustPressed) {
				nextVelocity.y = jumpSpeed;
				onGround = false;
			}
		} else {
			Vector2 raycastPos = transform.position;
			if (rigidbody2d.velocity.y <= 0 && Physics2D.Raycast (raycastPos,Vector2.down,boxcollider2d.size.y/2+0.05f,1<<0).collider != null) {
				onGround = true;
			}
		}

		rigidbody2d.velocity = nextVelocity;


		// Animation logic

		Vector3 nextScale = transform.localScale;

		if (rightHeldDown) {
			nextScale.x = 1;
		} else if (leftHeldDown) {
			nextScale.x = -1;
		}

		if (onGround) {
			
			if (rightHeldDown) {
				animator.Play ("Run");
			} else if (leftHeldDown) {
				animator.Play ("Run");
			} else {
				animator.Play ("Idle");
			}
		} else {
			if (jumpJustPressed) {
				animator.Play ("Jump");
			}
		}

		transform.localScale = nextScale;
	}
}
