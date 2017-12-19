using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawnScript : MonoBehaviour {

	[SerializeField]
	private GameObject bombPrefab;

	private GameObject spawnedObject;

	private List<GameObject> bombsInGame = new List<GameObject>();

	private void Start(){
		bombsInGame.Clear ();	
	}

	private void Update(){

		if (bombsInGame.Count == 0) {
			spawnedObject = Instantiate (bombPrefab, new Vector3 (transform.position.x, transform.position.y), Quaternion.identity);
			bombsInGame.Add (spawnedObject);
		}

		print (bombsInGame.Count);

	}

	public void RemoveBomb(){
		bombsInGame.Clear ();
	}

}