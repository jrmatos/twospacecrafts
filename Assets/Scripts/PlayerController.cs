using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpacecraftsPosition
{	
	public static class One{
		public static bool isInitial = true;
		public static float left = 0f;
		public static float right = 3.15f;
	}

	public static class Two{
		public static bool isInitial = true;
		public static float left = 6.35f;
		public static float right = 9.5f;
	}
}

public class PlayerController : MonoBehaviour {

	public GameObject spacecraftOne;
	public GameObject spacecraftTwo;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//GetInput ();
		//MoveSpacecrafts ();
	}

	void GetInput() {		
		if (Input.GetKeyDown (KeyCode.A)) {
			SpacecraftsPosition.One.isInitial = !SpacecraftsPosition.One.isInitial;
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			SpacecraftsPosition.Two.isInitial = !SpacecraftsPosition.Two.isInitial;
		}
	}

	void MoveSpacecrafts() {
		/*if (isSpacecraftOneInitialPosition) {
			
		} else {
			
		}*/
	}

}
