using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class BaseStats {

	public List<StatsBonus> BaseAdditives { get; set; }
	public int BaseValue { get; set; }
	public string StatName { get; set; }
	public string StatDescription { get; set; }
	public int FinalValue { get; set; }
	// Use this for initialization


	public BaseStats(int baseValue, string statName, string statDesc, int finalValue){


		this.BaseAdditives = new List<StatsBonus> ();
		this.BaseValue = baseValue;
		this.StatName = statName;
		this.StatDescription = statDesc;
		this.FinalValue = finalValue;

	}

	public void AddStatBonus(StatsBonus statBonus){


		this.BaseAdditives.Add (statBonus);
	}

	public void RemoveStatBonus(StatsBonus statBonusRemove){


		this.BaseAdditives.Remove (BaseAdditives.Find(x=> x.BonusValue == statBonusRemove.BonusValue));
	}

	public int GetCalculatedStatValue(){

		this.FinalValue = 0;
		this.BaseAdditives.ForEach (x => this.FinalValue += x.BonusValue);
		FinalValue += BaseValue;
		return FinalValue;

	}
}
