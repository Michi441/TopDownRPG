using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable {


	public string[] dialogue;
	public string NPC_name;


	public override void Interact(){


		DialogueSystem.Instance.AddDialogue (dialogue, NPC_name);
		Debug.Log ("interacting with npc!");

	}


}
