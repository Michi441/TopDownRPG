using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {


	public List<BaseStats> stats = new List<BaseStats> ();

	// Use this for initialization
	void Start () {


		stats.Add (new BaseStats (4, "Power", "Your Power Level!", 50));
		stats [0].AddStatBonus (new StatsBonus (5));
		Debug.Log (stats [0].GetCalculatedStatValue ());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
