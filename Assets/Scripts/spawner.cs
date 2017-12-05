using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	[SerializeField]
	private GameObject plataform;
	private float initialTime;
	[SerializeField]
	private float speed = 3f;
	private Rigidbody2D rigidbody2d;
	[SerializeField]
	private float timeToSpawn = 2f;
	private float position;


	private void Awake(){
	
		rigidbody2d = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate(){
		
		rigidbody2d.velocity =
			new Vector2 (transform.right.x*speed, 0f);
		
	}

	private void Update(){


		if(Time.time > initialTime + timeToSpawn){
			 
			Instantiate (
				plataform,
				new Vector3(transform.position.x,(transform.position.y)-1,0f),
				Quaternion.identity
			);
			initialTime = Time.time;
		}

	}
	private void OnCollisionEnter2D(Collision2D collision){
		if(collision.otherCollider){
			transform.Rotate(0f,180f,0f);
		}
		
	}
}
