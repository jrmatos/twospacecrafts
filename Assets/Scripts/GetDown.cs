﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDown : MonoBehaviour {

	public static float speed = 2f;
	private Vector3 tempPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tempPosition = transform.position;
		tempPosition.y -= speed * Time.deltaTime;
		transform.position = tempPosition;


		if (transform.position.y <= -6) {
			Destroy (gameObject);
		} 
	}
}