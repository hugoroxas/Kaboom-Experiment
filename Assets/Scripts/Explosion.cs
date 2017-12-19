using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	private float countDown= 1f;
		private float timerDelay;
	private void Start(){
	
		countDown = timerDelay;
	}

	private void Update(){

		countDown -= Time.deltaTime;
		if (countDown <= 0) {

			Destroy (gameObject);
		
		}
	}
}
