using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	[SerializeField]
	private GameObject plataform;
	private float initialTime;
	private float speed;
	private Rigidbody2D rigidbody2d;
	[SerializeField]
	private float timeToSpawn = 2f;
	private float position;

	private void Awake(){
		rigidbody2d = GetComponent<Rigidbody2D>();
	}
	private void Start(){


	}
	private void FixedUpdate(){
		
		rigidbody2d.velocity =
			new Vector2 (transform.right.x*speed,0f);
		
	}

	private void Update(){


		if(Time.time > initialTime + timeToSpawn){
			 
			Instantiate (
				plataform,
				new Vector3(transform.position.x,(transform.position.y)-1,0f),
				Quaternion.identity
			);
			speed = Random.Range (2f, 7f);
			initialTime = Time.time;
			//print (speed);
		}

	}
	private void OnCollisionEnter2D(Collision2D collision){
		if(collision.otherCollider){
			transform.Rotate(0f,180f,0f);
		}
		
	}
}
