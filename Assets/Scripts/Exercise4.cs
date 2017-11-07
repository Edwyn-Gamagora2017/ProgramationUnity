using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour {

	// Attributes
	[SerializeField]				// SerializeField is used to make the variable visible in the Unity's Inspector, by keeping it private or protected. Another solution is to make the variable public
	private string stringToCut;		// String to be used for printing each letter

	/*
	 * Prints a character in the Console
	 * @param character [char] Character to be printed
	 */
	private void print( char character ){
		// Print character
		Debug.Log ( character );
	}

	/*
	 * Prints a string (letter by letter) in the Console
	 * @param value [string] String to be printed
	 */
	private void printEachLetter( string value ){
		for (int i = 0; i < value.Length; i++) {
			this.print ( value[i] );
		}
	}

	// Use this for initialization
	void Start () {
		// Initializing values
		this.stringToCut = "";
	}
	
	// Update is called once per frame
	void Update () {
		// Print the string (letter by letter)
		this.printEachLetter( this.stringToCut );
	}
}
