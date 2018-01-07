using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsBonus {

	public int BonusValue { get; set; }
	public StatsBonus(int bonusValue){


		this.BonusValue = BonusValue;
		Debug.Log ("New stat bonus initialized");
	}
}
