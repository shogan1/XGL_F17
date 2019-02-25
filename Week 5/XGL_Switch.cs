using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XGL_Switch : MonoBehaviour
{

    // You can continue to add to the list of Behaviors in side the curly braces by adding a comma and then the 
    // behavior name
    public enum XGL_Switch_Behavior { Destroys, ChangesToRed, YourOwnBehavior1, YourOwnBehavior2 };

    // set through inspector
    public XGL_Switch_Behavior behavior;

    // You'll want to drag different game objects here through the inspector. This script will then do the
    // desired behavior on every game object in this array.
    public GameObject[] ThingsToAffect;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            for (int i = 0; i < ThingsToAffect.Length; i++) {
                GameObject g = ThingsToAffect[i];
                if (g == null) continue;
                // Ignore the above code

                // Here, you can add a new else if, if you want to add your own custom behaviors.
                if (behavior == XGL_Switch_Behavior.Destroys) {
                    g.SetActive(false);
                } else if (behavior == XGL_Switch_Behavior.ChangesToRed) {
                    g.GetComponent<SpriteRenderer>().color = Color.red;
                } else if (behavior == XGL_Switch_Behavior.YourOwnBehavior1) {

                }

                // Ignore the below code
            } 
        }
    }

}
