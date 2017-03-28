using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour {

	public void Resume() {
		GameObject.FindObjectOfType<GameManager> ().setGameover(false);	
	}

}
