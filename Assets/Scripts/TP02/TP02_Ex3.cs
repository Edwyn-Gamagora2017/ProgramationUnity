using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP02_Ex3 : MonoBehaviour {

	[SerializeField]
	GameObject objectToControl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (objectToControl != null) {
				objectToControl.SetActive ( !objectToControl.activeSelf );
			}
		}
	}
}
