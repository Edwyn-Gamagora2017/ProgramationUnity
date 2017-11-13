using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD02_Ex6 : MonoBehaviour {

	// Attributes
	[SerializeField]
	private GameObject objectToControl;		// Object to be controlled
	[SerializeField]
	private GameObject objectToFollow;		// Object to be followed

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (objectToControl != null && objectToFollow != null) {
			objectToControl.transform.LookAt (
				objectToFollow.transform
			);
		}
	}
}
