using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour, IEnemy{


	public float currentHealth, power, though;
	public float maxHealth;


	void Start(){


		currentHealth = maxHealth;
	}
	public void PerformAttack(){


	

	}


	public void TakeDamage(int amount){


		currentHealth -= amount;
		if (currentHealth <= 0) {

			NotAvaible ();
		}
		 
	}

	void NotAvaible(){


		Destroy (gameObject);
	}
}
