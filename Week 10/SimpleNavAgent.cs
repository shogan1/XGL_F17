using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleNavAgent : MonoBehaviour {
	NavMeshAgent agent;
	public Transform target;
	// Use this for initialization
	void Start () {
		agent = GetComponent <NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = target.position;
	}
}
