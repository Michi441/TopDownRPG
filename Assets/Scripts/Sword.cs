using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon {


	//Perfom SwordAttack
	public void PerfomAttackz ()
	{

		Debug.Log ("Sword Attack!");




	}

	// Get the public list of basestats.
	public List<BaseStats> Stats { get; set; }





}
