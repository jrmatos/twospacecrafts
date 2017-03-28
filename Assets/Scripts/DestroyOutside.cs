using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutside : MonoBehaviour {

	public float y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= y) {
			Destroy (gameObject);
		} 
	}
}
