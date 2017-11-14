using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP04_Ex02 : MonoBehaviour {

	[SerializeField]
	int maxCopies = 2;	// maximum amount of copies
	int nCopies = 0;	// current amount of copies

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter( Collision col ){
		Debug.Log ( "Collision" );

		if ( col.gameObject.name == "Player" ) {
			createCopy ();
		}
	}

	void createCopy(){
		if (nCopies < maxCopies) {
			Vector3 posObject = this.gameObject.transform.position;
			// Creating a random position based on the objects position
			posObject.Set (posObject.x + Random.Range (-1, 1) * 2, posObject.y, posObject.z + Random.Range (-1, 1) * 2);
			Instantiate (this.gameObject, posObject, Quaternion.identity);

			nCopies++;
		}
	}
}
