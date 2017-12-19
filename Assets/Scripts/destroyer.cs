using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	private Vector3 myPosition = new Vector3(7.91f, 1.08f);

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			other.transform.position = myPosition;
		}
		else
		{
			Destroy(other.gameObject);
		}
	}
}
