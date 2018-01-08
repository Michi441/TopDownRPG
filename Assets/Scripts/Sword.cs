using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon {


	Animator anim;


	void Start(){


		anim = GetComponent<Animator> ();
	}


	void OnTriggerEnter(Collider other){


		Debug.Log ("colliding!");
		Debug.Log ("Hit: " + other.name);

		if (other.tag == "Enemy") {


			other.GetComponent<IEnemy> ().TakeDamage (Stats [0].GetCalculatedStatValue ());
		}
	}

	//Perfom SwordAttack
	public void PerfomAttackz ()
	{


		anim.SetTrigger ("Attack");





	}

	// Get the public list of basestats.
	public List<BaseStats> Stats { get; set; }





}
