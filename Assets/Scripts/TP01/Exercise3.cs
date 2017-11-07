using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour {

	// Attributes
	[SerializeField]				// SerializeField is used to make the variable visible in the Unity's Inspector, by keeping it private or protected. Another solution is to make the variable public
	private int numberFactorial;	// Number used to calculate the factorial

	/*
	 * Calculate the factorial of a number (Recursive version)
	 * @param number [int] Number used to calculate the factorial
	 * @return [int] the factorial of the number
	 */
	private int factorialRec( int number ){
		// Exception in the case that number is smaller than 1
		if (number <= 0) {
			throw new UnityException ( "factorialRec Error : number parameter must be higher than 0" );
		}

		// Calculates factorial
		if (number == 1) {
			return number;
		} else {
			// factorial (x) = x * factorial(x-1)
			return number * factorialRec (number - 1);
		}
	}

	/*
	 * Calculate the factorial of a number (Iteractive version)
	 * @param number [int] Number used to calculate the factorial
	 * @return [int] the factorial of the number
	 */
	private int factorialIteractive( int number ){
		// Exception in the case that number is smaller than 1
		if (number <= 0) {
			throw new UnityException ( "factorialRec Error : number parameter must be higher than 0" );
		}

		int result = 1;		// stores the value of the factorial
		while (number > 1) {
			result *= number;
			number -= 1;
		}
		return result;
	}

	/*
	 * Prints an int value in the Console
	 * @param number [int] Number to be printed
	 */
	private void print( int number ){
		// Print number
		Debug.Log ( "The value is "+number.ToString() );
	}

	// Use this for initialization
	void Start () {
		// Initializing values
		numberFactorial = 0;
	}

	// Update is called once per frame
	void Update () {
		try{
			// print the factorial of numberFactorial in the console
			this.print( factorialRec( this.numberFactorial ) );
		}
		catch( UnityException ex ){
			Debug.Log( "The numberFactorial must be bigger than 0" );
		}
	}
}
