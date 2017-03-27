using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	private Vector3 rotationEuler;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update(){
		rotationEuler -= Vector3.forward * 80 * Time.deltaTime; //increment 80 degrees every second
		transform.rotation = Quaternion.Euler(rotationEuler);
	}
}
