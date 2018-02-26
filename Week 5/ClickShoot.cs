using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// attach this to anything, only once per scene. It will detect mouse clicks and apply forces to things as needed

// Uses a raycast to turn an object red and also apply a force to it.
public class ClickShoot : MonoBehaviour
{

    void Start()
    {
    }

    void FixedUpdate()
    {


        // Check if mouse was left-clicked
        if (Input.GetMouseButtonDown(0))
        {

            // Create a ray with origin at the camera and going *through* the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Creating a ray via a position and direction
          //  Ray ray2 = new Ray(transform.position,new Vector3(0,1,0));

            // Ray should go for 100 units

            // The string array can have other strings added to it so the layer mask you get from GetMask will
            // let you allow the raycast to hit other layers
            if (Physics.Raycast(ray, out hit, 100f,LayerMask.GetMask(new string[]{"Default","Someotherlayer"})))  
            {
                // You can also make a layermask that lets the raycast hit multiplelayers
              //  int multiLayerMask = LayerMask.GetMask(new string[]{ "Default", "Player"});

                // If it hits something, we can access that game object through our RaycastHit lik eso.
                // hit.collider.gameObject;


                // Change the color
                MeshRenderer mr = hit.collider.gameObject.GetComponent<MeshRenderer>();
                if (mr != null)
                {
                    mr.material.color = Color.red;
                }

                // Only apply a force if the gameObject HAS a rigidbody
                Rigidbody rb = hit.collider.gameObject.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    // Applies a force in direction of where camera faces
                    rb.AddForce(Camera.main.transform.forward*300f);
                }

            }


            // This is if you want only the object this script is attached to, to be interactable
            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.collider.gameObject.name == gameObject.name)
                {
                    // Do something...
                }
            }
        }
    }
}