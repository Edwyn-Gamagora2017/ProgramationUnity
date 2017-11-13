using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD03_Ex01 : MonoBehaviour {

	// Attributes
	[SerializeField]
	private GameObject objectToControl;		// Object to be controlled

	private float moveSpeed = 0;
	[SerializeField]
	private float maxSpeed = 1f;			// max speed of the object to control
	[SerializeField]
	private float velocityStep = 0.1f;		// step for increasing the speed when the key is pressed
	[SerializeField]
	private float rotationStep = 3f;		// step for increasing the rotation when the key is pressed

	/*
	 * Handling user interaction with the keyboard arrows
	 */
	private void handleKeyboard(){
		// Checking Keyboard : the user can press two arrows at the same time
		// Up Arrow
		if( Input.GetKeyDown( KeyCode.UpArrow ) ){
			Debug.Log ( "The user pressed the UP ARROW" );
			// Execute movement
			if (objectToControl != null) {
				objectToControl.transform.Rotate (
					Vector3.up,
					rotationStep
				);
			}
		}
		if( Input.GetKeyDown( KeyCode.DownArrow ) ){
			Debug.Log ( "The user pressed the DOWN ARROW" );
			// Execute movement
			if (objectToControl != null) {
				objectToControl.transform.Rotate (
					Vector3.up,
					-rotationStep
				);
			}
		}
		if( Input.GetKeyDown( KeyCode.LeftArrow ) ){
			Debug.Log ( "The user pressed the LEFT ARROW" );
			moveSpeed = Mathf.Max( moveSpeed - velocityStep, 0f );
		}
		if( Input.GetKeyDown( KeyCode.RightArrow ) ){
			Debug.Log ( "The user pressed the RIGHT ARROW" );
			moveSpeed = Mathf.Min( moveSpeed + velocityStep, maxSpeed );
		}

		// Removing Component when SPACE is pressed
		if( Input.GetKeyDown( KeyCode.Space ) ){
			Debug.Log ( "The user pressed the Keypad ENTER" );
			if (objectToControl != null) {
				//Destroy( objectToControl.GetComponent<MeshRenderer>() );
				//Destroy( objectToControl.GetComponent<BoxCollider>() );
				Destroy( objectToControl.GetComponent<Transform>() );
			}
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		this.handleKeyboard ();

		if (objectToControl != null) {
			objectToControl.transform.Translate (
				Vector3.forward * moveSpeed * Time.deltaTime
			);
		}
	}
}
