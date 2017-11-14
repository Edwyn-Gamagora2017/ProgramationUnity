﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP05_Ex04_PNJ : MonoBehaviour {

	public enum PNJ_Type{
		Normal, HighSpeed, HighAcceleration, HighDistance
	}

	[SerializeField]
	PNJ_Type pnjType;

	[SerializeField]
	int maxCopies = 10;	// maximum amount of copies
	int nCopies = 0;	// current amount of copies
	[SerializeField]
	float lifeTime = 5f;	// time to be destroyied

	MeshRenderer renderer;

	[SerializeField]
	private GameObject objectToFollow;		// Object to be followed
	[SerializeField]
	float maxDistance = 2f;						// Distance to keep between the objects

	private float moveSpeed = 0f;				// speed of the object to control

	private float maxSpeed;				// max speed of the object to control
	private float velocityStep;			// step for increasing the speed when the object is accelerating
	private float trackDistance;		// Minimun distance necessary to follow the object

	void Awake(){
		renderer = GetComponent<MeshRenderer> ();
		renderer.material.shader = Shader.Find ("Specular");
		setColor ( new Color( Random.Range (0, 255)/255f, Random.Range (0, 255)/255f, Random.Range (0, 255)/255f ) );

		// random type
		pnjType = (PNJ_Type)System.Enum.GetValues( typeof(PNJ_Type) ).GetValue( Random.Range (0, System.Enum.GetNames( typeof(PNJ_Type) ).Length ) );
	}

	// Use this for initialization
	void Start () {
		TP05_Ex04_Class pnjInfo = TP05_Ex04_Class.byType (pnjType);

		// Behaviour depends on the type
		this.maxSpeed = pnjInfo.getMaxSpeed();
		this.velocityStep = pnjInfo.getVelocityStep();
		this.trackDistance = pnjInfo.getTrackDistance();
	}

	// Update is called once per frame
	void Update () {
		lifeTime -= Time.deltaTime;
		if (lifeTime <= 0f) {
			Destroy (gameObject);
		}

		if (objectToFollow != null) {
			// Check distance
			float distance = Vector3.Magnitude( transform.position - objectToFollow.transform.position );
			if( distance <= trackDistance ){
				if (distance > maxDistance) {
					moveSpeed = Mathf.Min ((moveSpeed + velocityStep) * distance / trackDistance, maxSpeed);	// adjust speed when object is close
				}else{
					moveSpeed = 0f;
				}
			}

			// move
			transform.Translate (
				Vector3.forward * moveSpeed * Time.deltaTime
			);
			// Rotate
			if (objectToFollow != null) {
				transform.LookAt (
					objectToFollow.transform
				);
			}
		}
	}

	void OnCollisionEnter( Collision col ){
		Debug.Log ( "Collision" );

		if ( col.gameObject.name == "Player" ) {
			createCopy ();
		}
	}

	public void createCopy(){
		if (nCopies < maxCopies) {
			Vector3 posObject = this.gameObject.transform.position;
			// Creating a random position based on the objects position
			posObject.Set (posObject.x + Random.Range (-1, 1) * 2, posObject.y, posObject.z + Random.Range (-1, 1) * 2);
			Instantiate (this.gameObject, posObject, Quaternion.identity);

			nCopies++;
		}
	}

	public void setColor( Color c ){
		renderer.material.color = c;
	}
	public void setTarget( GameObject target ){
		objectToFollow = target;
	}
}