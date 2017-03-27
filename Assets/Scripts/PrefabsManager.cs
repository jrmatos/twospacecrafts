using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsManager : MonoBehaviour {

	public GameObject Blackhole;
	public GameObject Star;
	private GameObject Generic;

	public List<GameObject> prefabsList;

	// initial side = left
	public bool initialGeneralSide = true;

	// 0 = blackhole
	// 1 = star
	public float prefab; 

	// Use this for initialization
	void Start () {		
		prefabsList.Add (Blackhole);
		prefabsList.Add (Star);
		InvokeRepeating("GenerateGameObjects", 0f, 1f);
	}

	// Update is called once per frame
	void Update () {
	}

	void GenerateGameObjects() {

		Generic = (GameObject)Instantiate (prefabsList[Random.Range(0,2)]);

		if (initialGeneralSide) {
			if (Random.Range(0,2) == 1) {
				// esquerda / esquerda
				Generic.transform.position = new Vector3 (SpacecraftsPosition.One.left, 6, -3);
			} else {
				// esquerda / direita
				Generic.transform.position = new Vector3 (SpacecraftsPosition.One.right, 6, -3);
			}

		} else {
			if (Random.Range(0,2) == 1) {
				// esquerda / esquerda
				Generic.transform.position = new Vector3 (SpacecraftsPosition.Two.left, 6, -3);
			} else {
				// esquerda / direita
				Generic.transform.position = new Vector3 (SpacecraftsPosition.Two.right, 6, -3);
			}
		}

		initialGeneralSide = !initialGeneralSide;

	}
}
