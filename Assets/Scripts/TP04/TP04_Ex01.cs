using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP04_Ex01 : MonoBehaviour {

	[SerializeField]
	bool exampleReference = false;	// Determines if the object will have a behaviour that works with a reference type or value type

	// Use this for initialization
	void Start (){
		if (exampleReference) {
			// Reference Type
			Transform trans = transform;
			trans.position = new Vector3(0,2,0);
		} else {
			// Value Type
			Vector3 pos = transform.position;
			pos = new Vector3 (0, 2, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
