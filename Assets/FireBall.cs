using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {


	Vector3 spawnPosition;

	public Vector3 direction { get; set; }
	public float Range { get; set; }
	public int Damage { get; set; }

	// Use this for initialization
	void Start () {

		Range = 20f;
		Damage = 12;
		spawnPosition = transform.position;
		GetComponent<Rigidbody> ().AddForce (direction * 50f);
	}
	
	// Update is called once per frame
	void Update () {


		if (Vector3.Distance (spawnPosition, transform.position) >= Range) {


			Delete ();
		}
	}

	void OnCollisionEnter(Collision other){

		if (other.transform.tag == "Enemy") {

			other.transform.GetComponent<IEnemy> ().TakeDamage (Damage);
		} else {

			Delete ();

		}

	}

	void Delete(){

		Destroy (gameObject, 5f);

	}
}
