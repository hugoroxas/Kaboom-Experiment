using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour {

	private GameObject mySpawner;

	private void Start(){
		mySpawner = GameObject.FindGameObjectWithTag ("BombSpawner");
	}

	private void OnTriggerEnter2D(Collider2D other){

		if (other.CompareTag("Player")) {
			print ("Got it");
			mySpawner.GetComponent<BombSpawnScript>().RemoveBomb();
			Destroy (gameObject);

		}
	}
}
