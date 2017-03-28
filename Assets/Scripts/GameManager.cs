using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public bool gameover = false;
	public Text gameoverText;
	public Text scoreText;
	public Text gameoverScoreText;
	public Text gameoverHighScoreText;
	private ScoreManager scoreManager;
	CanvasGroup restartButtonCanvasGroup;

	private float initialTimeScale;

	// Use this for initialization
	void Start () {
		initialTimeScale = Time.timeScale;
		scoreManager = GameObject.FindObjectOfType<ScoreManager> ();
		restartButtonCanvasGroup = GameObject.Find("RestartButton").GetComponent<CanvasGroup>();
	}

	public bool isGameover(){
		return gameover;
	}

	public void setGameover(bool gameover) {
		this.gameover = gameover;

		if (this.gameover) {
			Time.timeScale = 0;
			showGameoverHUDs ();
		} else {
			Time.timeScale = initialTimeScale;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	void showGameoverHUDs() {

		gameoverScoreText.text = "Score: " + scoreManager.getScore();
		gameoverHighScoreText.text = "High Score: " + scoreManager.getHighScore();

		scoreText.GetComponent<Text> ().enabled = false;
		gameoverText.GetComponent<Text> ().enabled = true;
		gameoverScoreText.GetComponent<Text> ().enabled = true;
		gameoverHighScoreText.GetComponent<Text> ().enabled = true;

		restartButtonCanvasGroup.alpha = 1f;
		restartButtonCanvasGroup.interactable = true;
		restartButtonCanvasGroup.blocksRaycasts = true;
	}
}
