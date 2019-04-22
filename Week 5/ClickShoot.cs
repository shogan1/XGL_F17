using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach this to anything, only once per scene. It will detect mouse clicks and apply forces to things as needed
// Uses a raycast to turn an object red and also apply a force to it.
public class ClickShoot : MonoBehaviour
{

    //if true, you'll only be able to shoot things that have a Shootable tag (you'll need to create this tag in the editor)
    public bool onlyAffectShootables = false;

    public bool changesColor = false;

    // from 0 to 1 - affects how much your shot pushes something forward or up
    [Range(0,1)]
    public float upwardness = 0;

    // how hard you shoot the thing
    public float shotForce = 30f;


    void FixedUpdate()
    {


        // Check if mouse was left-clicked
        if (Input.GetMouseButtonDown(0))
        {

            // Create a ray with origin at the camera and going *through* the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // The string array can have other strings added to it so the layer mask you get from GetMask will
            // let you allow the raycast to hit other layers

            // You can limit a raycast to hitting things only on certain layers defined in unity.
            //  int multiLayerMask = LayerMask.GetMask(new string[]{ "Default", "Player"});
            if (Physics.Raycast(ray, out hit, 100f,LayerMask.GetMask(new string[]{"Default","Someotherlayer"})))  
            {

                if (!onlyAffectShootables || (onlyAffectShootables && hit.collider.tag == "Shootable")) {
                    // If it hits something, we can access that game object through our RaycastHit 

                    // Change the color
                    if (changesColor) {
                        MeshRenderer mr = hit.collider.gameObject.GetComponent<MeshRenderer>();
                        if (mr != null) {
                            mr.material.color = Color.red;
                        }
                    }

                    // Only apply a force ONLY if the gameObject has a rigidbody
                    Rigidbody rb = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if (rb != null) {
                        // Applies a force in direction of where camera faces
                        // the forward vector has length 1, we want a vector with length shotForce.
                        Vector3 forceDirection = Camera.main.transform.forward * shotForce;
                        // Lerp between forward vector and the up vector (0,1,0) depending on the upwardness setting
                        forceDirection = Vector3.Lerp(forceDirection, Vector3.up * shotForce, upwardness);
                        // add the force as an impulse (like a punch or kick)
                        rb.AddForce(forceDirection,ForceMode.Impulse);
                    }
                }

            }
        }
    }
}