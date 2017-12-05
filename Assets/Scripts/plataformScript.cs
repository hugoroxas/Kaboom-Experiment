using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformScript : MonoBehaviour {
	[SerializeField]
	private float speed = 3f;
	private float verticalMove;
	private Rigidbody2D rigidbody2d;


	private void Awake(){
		rigidbody2d = GetComponent <Rigidbody2D> ();
		 
			

	}
	private void FixedUpdate(){
	
		rigidbody2d.velocity= new Vector2 (0f,transform.up.y*-speed);
	}
		
}
