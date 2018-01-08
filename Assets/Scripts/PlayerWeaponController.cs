using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour {


	// get the gameobject for reference
	public GameObject playerHand;

	// get the eq weapon as an gameobject
	public GameObject EqWeapon { get; set; }

	// declare iweapon script as equippedweapon
	IWeapon equippedWeapon;

	// get the characterstats script
	CharacterStats characterStats;

	// Use this for initialization
	void Start () {

		// declare character stats 
		characterStats = GetComponent<CharacterStats> ();
	}

	// Equip weapon function,  uses Item as a reference to equip a weapon
	public void EquipWeapon(Item itemToEquip){


		if (EqWeapon != null) {

			// remove the stats bonus from eq weapon
			characterStats.RemoveStatBonues (EqWeapon.GetComponent<IWeapon> ().Stats);
			// destroy the gameobject (weapon).
			Destroy (playerHand.transform.GetChild (0).gameObject);
		} 

		// Instantiate the gameobject
		EqWeapon = (GameObject)Instantiate (Resources.Load<GameObject> ("Weapon/" + itemToEquip.ObjectSlug),
			playerHand.transform.position, playerHand.transform.rotation);
		equippedWeapon = EqWeapon.GetComponent<IWeapon> ();
		equippedWeapon.Stats = itemToEquip.Stats;
		EqWeapon.transform.SetParent (playerHand.transform);
		characterStats.AddStatBonus (itemToEquip.Stats);
		Debug.Log (equippedWeapon.Stats [0]);

	}


	public void PerfomWeaponAttack(){


		equippedWeapon.PerfomAttackz ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.X)) {


			PerfomWeaponAttack ();
		}
		
	}
}
