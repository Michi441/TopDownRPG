using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {

	public static DialogueSystem Instance { get; set; }

	public List<string> dialogueLines = new List<string>();



	public GameObject dialoguePanel;

	public string npcName;


	Button continueButton;
	Text dialogueText;
	int dialogueIndex;




	void Awake(){


		continueButton = dialoguePanel.transform.Find ("Button").GetComponent<Button> ();
		dialogueText = dialoguePanel.transform.Find ("Text").GetComponent<Text> ();


		continueButton.onClick.AddListener (delegate {
			ContinueText ();
		});

		if (Instance != null && Instance != this) {



		} else {


			Instance = this;
		}

		dialoguePanel.SetActive (false);
	}

	public void ContinueText(){


		if (dialogueIndex < dialogueLines.Count - 1) {


			dialogueIndex++;
			dialogueText.text = dialogueLines [dialogueIndex];
		} else { 
			dialoguePanel.SetActive (false);
		}
	}

	public void AddDialogue(string[] lines, string npcName){

		dialogueIndex = 0;
		dialogueLines = new List<string> ();
		foreach (string line in lines) {

			dialogueLines.Add (line);
			CreateDialogue ();

			Debug.Log (dialogueLines.Count);
		}

		this.npcName = npcName;

		print (npcName);



	}

	public void CreateDialogue(){

		dialogueText.text = dialogueLines [dialogueIndex];

		dialoguePanel.SetActive (true);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

}
