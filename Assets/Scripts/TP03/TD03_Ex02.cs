using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD03_Ex02 : MonoBehaviour {

	[SerializeField]
	GameObject objectToControl;

	/*
	 * Handling user interaction with the keyboard arrows
	 */
	private void handleKeyboard(){
		// Removing Component when SPACE is pressed
		if( Input.GetKeyDown( KeyCode.Space ) ){
			Debug.Log ( "The user pressed the Space" );
			Destroy( objectToControl.gameObject );
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		this.handleKeyboard ();
	}
}