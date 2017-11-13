using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD03_Ex03 : MonoBehaviour {

	// Attributes
	[SerializeField]						// SerializeField is used to make the variable visible in the Unity's Inspector, by keeping it private or protected. Another solution is to make the variable public
	private GameObject objectToControl;		// Object to be controlled

	[SerializeField]
	bool isRaw = false;

	/*
	 * Handling user interaction with the keyboard arrows
	 */
	private void handleAxis(){
		if (objectToControl != null) {
			// Getting current object's position
			Vector3 objectCurrentPosition = objectToControl.transform.position;

			if (isRaw) {
				// GetAxisRaw
				objectToControl.transform.position = new Vector3 (objectCurrentPosition.x + Input.GetAxisRaw ("Mouse X"), objectCurrentPosition.y + Input.GetAxisRaw ("Mouse Y"), objectCurrentPosition.z);
			} else {
				// GetAxis
				objectToControl.transform.position = new Vector3( objectCurrentPosition.x+Input.GetAxis("Mouse X"), objectCurrentPosition.y+Input.GetAxis("Mouse Y"), objectCurrentPosition.z );
			}
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		try{
			// Handling user interaction with the keyboard arrows
			this.handleAxis();
		}
		catch( UnityException ex ){
			// TODO detail exception
			Debug.Log( "objectToControl is not set" );
		}
	}
}
