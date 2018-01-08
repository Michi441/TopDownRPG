using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon {

	// Weapon has a list of BaseStats.cs, declared as Stats. 
	List<BaseStats> Stats { get; set; }





	void PerfomAttackz ();
}
