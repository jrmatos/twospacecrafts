using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDown : MonoBehaviour {

	public static float speed = 2f;
	public float speedIncreaseRate = 0.020f;
	private Vector3 tempPosition;

	// Use this for initialization
	void Start () {
		InvokeRepeating("IncreaseSpeed", 0f, 1f);
	}

	void IncreaseSpeed() {
		speed += speedIncreaseRate;
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
