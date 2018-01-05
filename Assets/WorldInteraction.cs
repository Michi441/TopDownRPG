using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WorldInteraction : MonoBehaviour {



	NavMeshAgent agent;

	// Use this for initialization
	void Start () {

		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject ()) {

			GetInteraction ();
		}
		
	}

	void GetInteraction(){



		Ray interactionRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (interactionRay, out hit, Mathf.Infinity)) {

			GameObject interactionObject = hit.collider.gameObject;
			if (interactionObject.tag == "Interact Object") {

				Debug.Log ("interaction detected");
			} else {

				agent.destination = hit.point;
			}	
		}
	}
}
