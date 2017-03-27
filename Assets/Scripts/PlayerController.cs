using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpacecraftsPosition
{	
	public static class One{
		public static bool isInitial = true;
		public static Vector3 position;
		public static float left = -4.7f;
		public static float right = -1.45f;
	}

	public static class Two{
		public static bool isInitial = true;
		public static Vector3 position;
		public static float left = 1.55f;
		public static float right = 4.85f;
	}
}

public class PlayerController : MonoBehaviour {


	public GameObject spacecraftOne;
	public GameObject spacecraftTwo;

	// Use this for initialization
	void Start () {
		spacecraftOne = GameObject.Find ("SpacecraftOne");
		spacecraftTwo = GameObject.Find ("SpacecraftTwo");
	}
	
	// Update is called once per frame
	void Update () {
		GetInput ();
		MoveSpacecrafts ();
	}

	void GetInput() {		
		// key A
		if (Input.GetKeyDown (KeyCode.A)) {
			SpacecraftsPosition.One.isInitial = !SpacecraftsPosition.One.isInitial;
		}

		// key D
		if (Input.GetKeyDown (KeyCode.D)) {
			SpacecraftsPosition.Two.isInitial = !SpacecraftsPosition.Two.isInitial;
		}
	}

	void MoveSpacecrafts() {
		
		// save current positions
		SpacecraftsPosition.One.position = spacecraftOne.transform.position;
		SpacecraftsPosition.Two.position = spacecraftTwo.transform.position;

		// update spacecraft one x
		if (SpacecraftsPosition.One.isInitial) {
			SpacecraftsPosition.One.position.x = SpacecraftsPosition.One.left;
		} else {
			SpacecraftsPosition.One.position.x = SpacecraftsPosition.One.right;
		}

		// update spacecraft two x
		if (SpacecraftsPosition.Two.isInitial) {
			SpacecraftsPosition.Two.position.x = SpacecraftsPosition.Two.left;
		} else {
			SpacecraftsPosition.Two.position.x = SpacecraftsPosition.Two.right;
		}

		// update positions
		spacecraftOne.transform.position = SpacecraftsPosition.One.position;
		spacecraftTwo.transform.position = SpacecraftsPosition.Two.position;
	}

}
