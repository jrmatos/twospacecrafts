using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsManager : MonoBehaviour {

	public GameObject Blackhole;
	public GameObject Star;
	private GameObject Generic;
	private Vector2 textureVellocity;

	private ScrollTexture scrollTexture;

	float generateRate = 1f;

	public List<GameObject> prefabsList;

	// initial side = left
	public bool initialGeneralSide = true;

	// 0 = blackhole
	// 1 = star
	public float prefab; 

	// Use this for initialization
	void Start () {		
		scrollTexture = GameObject.FindObjectOfType<ScrollTexture> ();
		prefabsList.Add (Blackhole);
		prefabsList.Add (Star);
		InvokeRepeating("decreaseRate", 0f, 1f);
		Invoke ("GenerateGameObjects", generateRate);
	}

	void decreaseRate() {
		generateRate -= 0.03f;
	}

	// Update is called once per frame
	void Update () {
	}

	void GenerateGameObjects() {

		Generic = (GameObject)Instantiate (prefabsList[Random.Range(0,2)]);

		if (initialGeneralSide) {
			if (Random.Range(0,2) == 1) {
				// esquerda / esquerda
				Generic.transform.position = new Vector3 (SpacecraftsPosition.One.left, 6, -1);
			} else {
				// esquerda / direita
				Generic.transform.position = new Vector3 (SpacecraftsPosition.One.right, 6, -1);
			}

		} else {
			if (Random.Range(0,2) == 1) {
				// esquerda / esquerda
				Generic.transform.position = new Vector3 (SpacecraftsPosition.Two.left, 6, -1);
			} else {
				// esquerda / direita
				Generic.transform.position = new Vector3 (SpacecraftsPosition.Two.right, 6, -1);
			}
		}

		initialGeneralSide = !initialGeneralSide;

		// increase texture speed
		textureVellocity = ScrollTexture.scrollVelocity;
		textureVellocity.y += 0.02f;
		ScrollTexture.scrollVelocity = textureVellocity;
		Invoke ("GenerateGameObjects", generateRate);

	}
}
