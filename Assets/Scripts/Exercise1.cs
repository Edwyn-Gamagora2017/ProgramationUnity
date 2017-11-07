using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour {

	// Attributes
	[SerializeField]			// SerializeField is used to make the variable visible in the Unity's Inspector, by keeping it private or protected. Another solution is to make the variable public
	private int monChiffre;

	[SerializeField]			// SerializeField is used to make the variable visible in the Unity's Inspector, by keeping it private or protected. Another solution is to make the variable public
	int x;

	// Use this for initialization
	void Start () {
		// Initializing values
		monChiffre = 3;
		x = 1;
	}
	
	// Update is called once per frame
	void Update () {
		// a) Affichez le contenu de la variable monChiffre ici
		// Showing the value of monChiffre
		Debug.Log( "The value of monChiffre is "+monChiffre.ToString() );

		// b) Affichez le contenu de la variable x ici
		// Showing the value of x
		Debug.Log( "The value of X is "+x.ToString() );

		// c) Affichez le resultat de la multiplication de x par monChiffre
		// Showing the X * monChiffre
		Debug.Log( "The value of (X * monChiffre ) is "+(x*monChiffre).ToString() );
	}
}
