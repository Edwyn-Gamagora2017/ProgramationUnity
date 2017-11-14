using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP05_Ex03 : MonoBehaviour {

	GameObject[] objects;
	List<MeshRenderer> renderers;

	// Use this for initialization
	void Start () {
		objects = GameObject.FindGameObjectsWithTag ( "Cube" );

		renderers = new List<MeshRenderer> ();
		foreach (GameObject g in objects) {
			MeshRenderer r = g.GetComponent<MeshRenderer> ();
			r.material.shader = Shader.Find ("Specular");
			renderers.Add (r);
		}
	}
	
	// Update is called once per frame
	void Update () {
		foreach( MeshRenderer r in renderers ){
			r.material.color = new Color( Random.Range (0, 255)/255f, Random.Range (0, 255)/255f, Random.Range (0, 255)/255f );
		}
	}
}
