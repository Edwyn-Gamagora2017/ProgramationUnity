using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD03_Ex01 : MonoBehaviour {
	
	private float moveSpeed = 0;
	[SerializeField]
	private float maxSpeed = 5f;			// max speed of the object to control
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
		if( Input.GetKey( KeyCode.UpArrow ) ){
			Debug.Log ( "The user pressed the UP ARROW" );
			// Execute movement
			transform.Rotate (
				Vector3.up,
				rotationStep
			);
		}
		if( Input.GetKey( KeyCode.DownArrow ) ){
			Debug.Log ( "The user pressed the DOWN ARROW" );
			// Execute movement
			transform.Rotate (
				Vector3.up,
				-rotationStep
			);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log ( "The user pressed the RIGHT ARROW" );
			moveSpeed = Mathf.Min (moveSpeed + velocityStep, maxSpeed);
		} else {
			moveSpeed = Mathf.Max (moveSpeed - velocityStep, 0);
		}

		// Removing Component when SPACE is pressed
		if( Input.GetKeyDown( KeyCode.Space ) ){
			Debug.Log ( "The user pressed the Space" );
			// Remove Component
			//Destroy( GetComponent<MeshRenderer>() );
			//Destroy( GetComponent<BoxCollider>() );

			// Cause Error
			//Destroy( GetComponent<Transform>() );
			// Solution to the error
			//Destroy( this.gameObject );
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		this.handleKeyboard ();

		transform.Translate (
			Vector3.forward * moveSpeed * Time.deltaTime
		);
	}
}
