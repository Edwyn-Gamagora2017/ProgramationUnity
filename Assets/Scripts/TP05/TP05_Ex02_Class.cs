using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP05_Ex02_Class {

	private int[] values;

	public TP05_Ex02_Class(){
		this.values = null;
		//this.values = new int[1]{ -1 };	// One item array
	}

	public TP05_Ex02_Class( int[] newValues ){
		this.setValues (newValues);
	}

	public void setValues( int[] newValues ){
		this.values = newValues;
	}

	public void print(){
		foreach( int v in this.values ){
			Debug.Log ( v.ToString() );
		}
	}
}
