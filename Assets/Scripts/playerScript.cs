using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {
	[SerializeField]
	private float jump;
	private float horizontalMove;
	[SerializeField]
	private float speed=2f;
	private Rigidbody2D myRigidbody2D;
	private bool grounded=false;

	private void Awake(){

		myRigidbody2D = GetComponent<Rigidbody2D> ();
	}
	private void Update(){
		if (Input.GetKeyDown (KeyCode.Space)|| Input.GetKeyDown(KeyCode.UpArrow)
			||Input.GetKeyDown(KeyCode.W)){
				if (grounded) {
					myRigidbody2D.velocity = new Vector2 (myRigidbody2D.velocity.x, jump);
				}else{
			if (Input.GetKeyUp (KeyCode.Space) || Input.GetKeyUp (KeyCode.UpArrow)
			    || Input.GetKeyUp (KeyCode.W)) {
					myRigidbody2D.velocity = new Vector2 (myRigidbody2D.velocity.x, myRigidbody2D.position.y);
				}
			}
		}

		horizontalMove = Input.GetAxis ("Horizontal");
	}
	private void FixedUpdate (){


		myRigidbody2D.velocity =
			new Vector2 (horizontalMove*speed,myRigidbody2D.velocity.y);

	}
	private void OnTriggerEnter2D(Collider2D other){
	grounded = true;
		print ("on the floor");
}
	private void OnTriggerExit2D(Collider2D other){
	grounded = false;
		print ("on the air");
}

}
