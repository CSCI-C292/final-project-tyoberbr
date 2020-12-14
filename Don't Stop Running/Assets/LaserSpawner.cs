using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
	public GameObject[] obj;
	public float spawnMin = 3f;
	public float spawnMax = 2f;
	
	void Start () {
		Spawn ();
	}
	
	void Spawn(){
		float rand = Random.Range (0, 1000);
		if (rand > 1) {
			Instantiate (obj [Random.Range (0, obj.GetLength (0))], transform.position, Quaternion.identity);
		}
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
	
}

