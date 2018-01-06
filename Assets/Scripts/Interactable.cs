using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Interactable : MonoBehaviour {

	public NavMeshAgent playerAgent;


	public virtual void MoveToInteraction(NavMeshAgent playerAgent){


		this.playerAgent = playerAgent;
		playerAgent.stoppingDistance = 5f;
		playerAgent.destination = this.transform.position;


		Interact ();
	}


	public virtual void Interact(){



		Debug.Log ("interacting with base class!");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
