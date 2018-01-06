using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable {


	public string[] dialogue;


	public override void Interact(){


		DialogueSystem.Instance.AddDialogue (dialogue);
		Debug.Log ("interacting with npc!");

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
