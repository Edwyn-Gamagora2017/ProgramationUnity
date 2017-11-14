using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP05_Ex01 : MonoBehaviour {

	const int nFibonacci = 10;

	int[] fibonacciValues;

	// Use this for initialization
	void Start () {
		fibonacciValues = new int[ nFibonacci+1 ];
		for( int i = 0; i < fibonacciValues.Length; i++ ){
			fibonacciValues [i] = -1;
		}

		//calcFibonacciRec( nFibonacci );
		calcFibonacciIteractive( nFibonacci );

		for( int i = 0; i < fibonacciValues.Length; i++ ){
			Debug.Log ( "Fib("+i.ToString()+") = "+fibonacciValues[i].ToString() );
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int calcFibonacciRec( int n ){
		if ( n < fibonacciValues.Length && n >= 0 ) {
			if( fibonacciValues[n] == -1 ){
				if (n == 0 || n == 1) {
					fibonacciValues [n] = 1;
				} else {
					fibonacciValues [n] = calcFibonacciRec(n-1) + calcFibonacciRec(n-2);
				}
			}
			return fibonacciValues[n];
		}
		return -1;	// default value : not defined
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
