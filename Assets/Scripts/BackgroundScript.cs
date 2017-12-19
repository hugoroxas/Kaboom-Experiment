using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour {
	[SerializeField]
	private float speed;
	private Vector3 startingPosition;

	private void Start(){
	
		startingPosition = transform.position;
	}

	private void Update(){
	
		transform.Translate ((new Vector3 (0f, -1f, 0f)) * speed * Time.deltaTime);
		if(transform.position.y <-5.05f) 
			transform.position = startingPosition;
	}
}
