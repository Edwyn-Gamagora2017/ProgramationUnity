using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour {

	// Attributes
	[SerializeField]						// SerializeField is used to make the variable visible in the Unity's Inspector, by keeping it private or protected. Another solution is to make the variable public
	private GameObject objectToControl;		// Object to be controlled

	/*
	 * Handling user interaction with the keyboard arrows
	 */
	private void handleKeyboard(){
		// Checking Keyboard : the user can press two arrows at the same time
		// Up Arrow
		if( Input.GetKeyDown( KeyCode.UpArrow ) ){
			Debug.Log ( "The user pressed the UP ARROW" );
			// Execute movement
			this.moveObject ( this.objectToControl, KeyCode.UpArrow );
		}
		if( Input.GetKeyDown( KeyCode.DownArrow ) ){
			Debug.Log ( "The user pressed the DOWN ARROW" );
			// Execute movement
			this.moveObject ( this.objectToControl, KeyCode.DownArrow );
		}
		if( Input.GetKeyDown( KeyCode.LeftArrow ) ){
			Debug.Log ( "The user pressed the LEFT ARROW" );
			// Execute movement
			this.moveObject ( this.objectToControl, KeyCode.LeftArrow );
		}
		if( Input.GetKeyDown( KeyCode.RightArrow ) ){
			Debug.Log ( "The user pressed the RIGHT ARROW" );
			// Execute movement
			this.moveObject ( this.objectToControl, KeyCode.RightArrow );
		}
	}

	/*
	 * Update object's position depending on the pressed key
	 * @param objectToMove [GameObject] object to be controlled
	 * @param direction [KeyCode] pressed key
	 */
	private void moveObject( GameObject objectToMove, KeyCode direction ){
		// Exception in the case that the objetc is null
		if (objectToMove == null) {
			throw new UnityException ("moveObject Error : objectToControl is not set");
		} else {
			// Getting current object's position
			Vector3 objectCurrentPosition = objectToMove.transform.position;
			// Updating object's position depending on the pressed key
			switch( direction ){
			case KeyCode.UpArrow:
				// moving object's Y coordinate
				objectToMove.transform.position = new Vector3( objectCurrentPosition.x, objectCurrentPosition.y+1, objectCurrentPosition.z );
				break;
			case KeyCode.DownArrow:
				// moving object's Y coordinate
				objectToMove.transform.position = new Vector3( objectCurrentPosition.x, objectCurrentPosition.y-1, objectCurrentPosition.z );
				break;
			case KeyCode.RightArrow:
				// moving object's X coordinate
				objectToMove.transform.position = new Vector3( objectCurrentPosition.x+1, objectCurrentPosition.y, objectCurrentPosition.z );
				break;
			case KeyCode.LeftArrow:
				// moving object's X coordinate
				objectToMove.transform.position = new Vector3( objectCurrentPosition.x-1, objectCurrentPosition.y, objectCurrentPosition.z );
				break;
			default:
				break;
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
			this.handleKeyboard();
		}
		catch( UnityException ex ){
			// TODO detail exception
			Debug.Log( "objectToControl is not set" );
		}
	}
}
