using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

	private ScoreManager scoreManager;
	private GameManager gameManager;

	// Use this for initialization
	void Start () {
		scoreManager = GameObject.FindObjectOfType<ScoreManager> ();
		gameManager = GameObject.FindObjectOfType<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameManager.isGameover ()) {
			checkGameover ();
		} 
	}

	void checkGameover() {
		if (transform.position.y <= -4.2) {
			gameManager.setGameover (true);
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.CompareTag ("Player")) {			
			scoreManager.AddScore (1);
			Destroy (gameObject);
		}
	}

}
