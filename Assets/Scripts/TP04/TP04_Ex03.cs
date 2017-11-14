using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP04_Ex03 : MonoBehaviour {

	[SerializeField]
	GameObject objectToReproduce;
	[SerializeField]
	int nCopies;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < nCopies; i++) {
			createPNJ ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void createPNJ(){
		// Creating a random position
		Vector3 posObject = new Vector3(Random.Range (-5, 5), 0, Random.Range (-5, 5));
		GameObject obj = Instantiate ( objectToReproduce, posObject, Quaternion.identity );
		obj.GetComponent<TP04_Ex03_PNJ> ().setColor ( new Color( Random.Range (0, 255)/255f, Random.Range (0, 255)/255f, Random.Range (0, 255)/255f ) );
	}
}
