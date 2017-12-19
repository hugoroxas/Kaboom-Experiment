using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

	private Rigidbody2D bombRigidbody;

	private float timerDelay=1f;
	private float countDown;
	private bool didBlowUp= false;
	[SerializeField]
	private GameObject explosion;

	private void Awake(){
	

		bombRigidbody = GetComponent<Rigidbody2D> ();

	}
		
	private void Start(){
		countDown = timerDelay;
	}
	private void Update(){
	
		countDown -= Time.deltaTime;
		if(countDown <= 0 && !didBlowUp){
			BlowUp ();
		}
	}
	private void BlowUp(){
	
		Instantiate (
			explosion, transform.position, Quaternion.identity
		);

			Destroy (gameObject);
	}
		
}
