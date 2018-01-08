using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Interactable : MonoBehaviour {

	public NavMeshAgent playerAgent;

	public bool hasInteracted;
	public virtual void MoveToInteraction(NavMeshAgent playerAgent){


		hasInteracted = false;
		this.playerAgent = playerAgent;
		playerAgent.stoppingDistance = 2f;
		playerAgent.destination = this.transform.position;



	
	}


	public virtual void Interact(){



		Debug.Log ("interacting with base class!");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (!hasInteracted && playerAgent != null && !playerAgent.pathPending) {


			if (playerAgent.remainingDistance <= playerAgent.stoppingDistance && !playerAgent.pathPending) {


				hasInteracted = true;
				Interact ();
			}

		}
	
	}
}
