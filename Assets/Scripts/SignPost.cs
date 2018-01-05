using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPost : ActionItem {


	public override void Interact(){



		base.Interact ();

		Debug.Log ("interacting with sign post!");
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
