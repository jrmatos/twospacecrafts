using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private Text text;
	private int score = 0;
	private int highScore = 0;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		text.text = "" + score;
	}

	public int getScore() {
		return score;
	}

	public int getHighScore() {
		return highScore;
	}

	public void AddScore(int points){
		score += points;
		text.text = "" + score;

		if (score > highScore) {
			highScore = score;
		}
	}
}
