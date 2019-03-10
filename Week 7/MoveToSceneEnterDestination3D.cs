using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1. Click on FPSController in your scene
// 2. Click on 'open' in the Inspector so you can edit the FPSController Prefab
// 3. In the hierarchy, a blue cube and then FPSController should be at the top
// 4. Click on the Grey cube FPS Controller in the hierarchy
// 5. Drag this script onto the inspector panel for the FPScontroller
// 6. You're done! Now if this FPS controller walks into a 3D trigger with a SceneChangeTrigger on it,
//    You can teleport to another location in another scene (or the same scene)
public class MoveToSceneEnterDestination3D : MonoBehaviour
{
    void Start()
    {
        Vector3 oldPos = transform.position;
        SceneChangeTrigger.moveSomethingToStoredDestination(transform);
        GetComponent<CharacterController>().Move(transform.position - oldPos);
    }

}
