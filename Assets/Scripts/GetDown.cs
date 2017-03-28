using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDown : MonoBehaviour {

	public static float speed = 1f;
	public float speedIncreaseRate = 0f;
	private Vector3 tempPosition;

	private GameManager gameManager;

	// Use this for initialization
	void Start () {
		InvokeRepeating("IncreaseSpeed", 0f, 1f);
		gameManager = GameObject.FindObjectOfType<GameManager> ();
	}

	void IncreaseSpeed() {
		if (speed <= 10) {
			speed += speedIncreaseRate;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameManager.isGameover ()) {
			tempPosition = transform.position;
			tempPosition.y -= speed * Time.deltaTime;
			transform.position = tempPosition;
		} else {
			Destroy (gameObject);
		}
	}
}
