using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool gameover = false;

	private float initialTimeScale;

	// Use this for initialization
	void Start () {
		initialTimeScale = Time.timeScale;
	}

	public bool isGameover(){
		return gameover;
	}

	public void setGameover(bool gameover) {
		this.gameover = gameover;

		if (this.gameover) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = initialTimeScale;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
