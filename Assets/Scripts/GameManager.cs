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


	// Use this for initialization
	void Start () {
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
		} else {
			Time.timeScale = 1f;
			scoreManager.setScore (0);

			GetDown.speed = 1f;
			PrefabsManager.generateRate = 1f;
			Vector2 t = ScrollTexture.scrollVelocity;
			t.y = 0;
			ScrollTexture.scrollVelocity = t;
		}

		toggleGameoverHUDs ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void toggleGameoverHUDs() {

		gameoverScoreText.text = "Score: " + scoreManager.getScore();
		gameoverHighScoreText.text = "High Score: " + scoreManager.getHighScore();

		scoreText.GetComponent<Text> ().enabled = !scoreText.GetComponent<Text> ().enabled;
		gameoverText.GetComponent<Text> ().enabled = !gameoverText.GetComponent<Text> ().enabled;
		gameoverScoreText.GetComponent<Text> ().enabled = !gameoverScoreText.GetComponent<Text> ().enabled;
		gameoverHighScoreText.GetComponent<Text> ().enabled = !gameoverHighScoreText.GetComponent<Text> ().enabled;

		restartButtonCanvasGroup.alpha = (restartButtonCanvasGroup.alpha == 1f) ? 0f : 1f;
		restartButtonCanvasGroup.interactable = !restartButtonCanvasGroup.interactable;
		restartButtonCanvasGroup.blocksRaycasts = !restartButtonCanvasGroup.blocksRaycasts;
	}
}
