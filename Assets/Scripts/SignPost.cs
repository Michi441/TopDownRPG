using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPost : ActionItem {


	public string[] dialogue;


	public override void Interact(){


		DialogueSystem.Instance.AddDialogue (dialogue, npcName:"Sign");

		base.Interact ();

		Debug.Log ("interacting with sign post!");
	}

}
