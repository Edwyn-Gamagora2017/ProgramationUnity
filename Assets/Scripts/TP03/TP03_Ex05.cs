﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP03_Ex05 : MonoBehaviour {

	int collisions = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter( Collision col ){
		Debug.Log ( "Collision" );
		collisions++;

		MeshRenderer renderer = GetComponent<MeshRenderer> ();
		renderer.material.shader = Shader.Find ("Specular");
		renderer.material.color = Color.green;

		if (collisions == 3) {
			Destroy ( gameObject );
		}
	}
}
