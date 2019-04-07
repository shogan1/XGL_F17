using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetweenPositions : MonoBehaviour
{

    [System.Serializable]
    public class MoveBetweenPositionsInfo {
        public float waitingTime = 0.5f;
        public float movementTimeToHere = 1f;
        public Transform _transform;
    }

    public MoveBetweenPositionsInfo[] positionInfos;

    Vector3 previousPosition = new Vector3();
    Vector3 temporaryPosition = new Vector3();

    int state = 0;
    int STATE_WAITING = 0;
    int STATE_MOVING = 1;

    float timer = 0;

    int currentPositionIndex = 0; // Keeps track of which position to move to.

    private void Start() {
        transform.position = positionInfos[0]._transform.position;
    }

    void Update()
    {
        if (state == STATE_WAITING) {
            timer = timer + Time.deltaTime;
            if (timer > positionInfos[currentPositionIndex].waitingTime) {
                previousPosition = transform.position;
                state = STATE_MOVING;
                timer = 0;
                currentPositionIndex++;
                if (currentPositionIndex == positionInfos.Length) {
                    currentPositionIndex = 0;
                }
            }
        } else if (state == STATE_MOVING) {
            timer = timer + Time.deltaTime;
            float movementTime = positionInfos[currentPositionIndex].movementTimeToHere;
            transform.position = Vector3.Lerp(previousPosition, positionInfos[currentPositionIndex]._transform.position, timer / movementTime);


            if (timer > positionInfos[currentPositionIndex].movementTimeToHere) {
                state = STATE_WAITING;
                timer = 0;
            }
        }
    }
}
