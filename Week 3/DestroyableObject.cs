using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{

    // If a object overlapping this object, has this tag, then this object will be destroyed.
    public string tagToBeDestroyedBy = "Explosive";

    // This is a special Unity function that runs every single time that another game object's collider
    // enters this object's collider.

    // This function has one input parameter called 'collision' which is a object that has type "Collision2D"

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == tagToBeDestroyedBy) {
            Object.Destroy(gameObject);
        }
    }

}
