using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class pencilline : MonoBehaviour {

	public GameObject obj;
	
	float lastx = 0f;
	void Start () {
		
	}
	
	void Update () {
		
		
		if (transform.position.x > (lastx+0.02f)) {
			
			
			Instantiate (obj,transform.position,Quaternion.identity);
			lastx = transform.position.x;
			
			lastx = transform.position.x;
			
		}
		
	}
}