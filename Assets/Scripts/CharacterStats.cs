using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {


	public List<BaseStats> stats = new List<BaseStats> ();

	// Use this for initialization
	void Start () {


		stats.Add (new BaseStats (4, "Power", "Your Power Level!", 50));
		stats.Add (new BaseStats (2, "Vitality", "Your Vitality Level!", 60));
		stats [0].AddStatBonus (new StatsBonus (5));
		Debug.Log (stats [0].GetCalculatedStatValue ());
		
	}

	public void AddStatBonus(List<BaseStats> statBonuses){


		foreach (BaseStats statBonus in statBonuses) {

			stats.Find (x => x.StatName == statBonus.StatName).AddStatBonus (new StatsBonus (statBonus.BaseValue));

		}
	}

	public void RemoveStatBonues(List<BaseStats> statBonuses){


		foreach (BaseStats statBonus in statBonuses) {


			stats.Find (x => x.StatName == statBonus.StatName).RemoveStatBonus (new StatsBonus (statBonus.BaseValue));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
