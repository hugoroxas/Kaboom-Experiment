using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	[SerializeField]
	private Rigidbody2D myRigidbody2D;

	[SerializeField]
	private GameObject explosionPrefab;

	public void ShootDirection( Vector3 direction ){
	
		myRigidbody2D.velocity = direction * 3f;

	}

	private void OnCollisionEnter2D(Collision2D other){

		Instantiate (explosionPrefab, transform.position, Quaternion.identity);

	}

}
