using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {

	public PlayerWeaponController playerWeaponController;
	public Item sword;
	// Use this for initialization
	void Start () {



		playerWeaponController = GetComponent<PlayerWeaponController> ();
		List<BaseStats> swordStats = new List<BaseStats> ();
		swordStats.Add (new BaseStats (6, "Power", "Your Power Level", 90));
		sword = new Item(swordStats, "staff");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.V)) {


			playerWeaponController.EquipWeapon (sword);
		}
		
	}
}
