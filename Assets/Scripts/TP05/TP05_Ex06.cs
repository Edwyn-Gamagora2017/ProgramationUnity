using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP05_Ex06 : MonoBehaviour {

	TP05_Ex06_Class<int> storage;

	const int nFibonacci = 10;

	int[] fibonacciValues;

	// Use this for initialization
	void Start () {
		fibonacciValues = new int[ nFibonacci+1 ];
		for( int i = 0; i < fibonacciValues.Length; i++ ){
			fibonacciValues [i] = -1;
		}

		calcFibonacciIteractive( nFibonacci );

		// Empty constructor
		/*
		storage = new TP05_Ex06_Class<int> ();
		storage.setValues ( fibonacciValues );
		*/
		// One parameter constructor
		storage = new TP05_Ex06_Class<int> (fibonacciValues);

		// printing stored value
		storage.print ();
	}

	// Update is called once per frame
	void Update () {

	}

	int calcFibonacciIteractive( int n ){
		if ( n < fibonacciValues.Length && n >= 0 ) {
			for (int i = 0; i <= n; i++) {
				if (i == 0 || i == 1) {
					fibonacciValues [i] = 1;
				} else {
					fibonacciValues [i] = fibonacciValues [i - 1] + fibonacciValues [i - 2];
				}
			}
			return fibonacciValues[n];
		}
		return -1;	// default value : not defined
	}
}