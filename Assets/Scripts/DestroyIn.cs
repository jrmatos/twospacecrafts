using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIn : MonoBehaviour {

	public float seconds = 0f;

	// Use this for initialization
	void Start () {
		Invoke ("destroyMe", seconds);
	}
	
	// Update is called once per frame
	void destroyMe () {
		Destroy (gameObject);
	}
}
