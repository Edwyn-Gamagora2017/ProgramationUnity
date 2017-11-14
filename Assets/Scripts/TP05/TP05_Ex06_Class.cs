using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP05_Ex06_Class<T> {

	private T[] values;

	public TP05_Ex06_Class(){
		this.values = null;
		//this.values = new int[1]{ -1 };	// One item array
	}

	public TP05_Ex06_Class( T[] newValues ){
		this.setValues (newValues);
	}

	public void setValues( T[] newValues ){
		this.values = newValues;
	}

	public void print(){
		foreach( T v in this.values ){
			Debug.Log ( v.ToString() );
		}
	}
}

