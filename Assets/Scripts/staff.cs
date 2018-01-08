using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staff : MonoBehaviour, IWeapon, IProjectileWeapon {


	Animator anim;


	public Transform ProjectileSpawn { get; set; }
	FireBall fireBall;
	void Start(){

		fireBall = Resources.Load<FireBall> ("Weapon/Projectiles/FireBall");
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

	public void CastProjectile(){



		FireBall fireBallInstance = (FireBall)Instantiate (fireBall, ProjectileSpawn.transform.position, transform.rotation);
		fireBallInstance.direction = ProjectileSpawn.forward;
	}


	// Get the public list of basestats.
	public List<BaseStats> Stats { get; set; }





}
