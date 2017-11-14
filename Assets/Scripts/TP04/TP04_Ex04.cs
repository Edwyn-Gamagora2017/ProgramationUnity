using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP04_Ex04 : MonoBehaviour {

	[SerializeField]
	GameObject objectToReproduce;
	[SerializeField]
	int nCopies;
	[SerializeField]
	int timeToCopy;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < nCopies; i++) {
			InvokeRepeating ("createPNJ", 0, timeToCopy);
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			CancelInvoke ("createPNJ");
		}
	}

	void createPNJ(){
		// Creating a random position
		Vector3 posObject = new Vector3(Random.Range (-5, 5), 0, Random.Range (-5, 5));
		GameObject obj = Instantiate ( objectToReproduce, posObject, Quaternion.identity );
	}
}
