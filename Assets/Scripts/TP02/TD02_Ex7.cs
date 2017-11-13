using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD02_Ex7 : MonoBehaviour {

	// Attributes
	[SerializeField]
	private GameObject objectToControl;		// Object to be controlled
	[SerializeField]
	private GameObject objectToFollow;		// Object to be followed

	[SerializeField]
	float trackDistance = 4f;					// Minimun distance necessary to follow the object
	[SerializeField]
	float maxDistance = 2f;						// Distance to keep between the objects

	private float moveSpeed = 0f;				// speed of the object to control
	[SerializeField]
	private float maxSpeed = 1f;					// max speed of the object to control
	[SerializeField]
	private float velocityStep = 0.1f;			// step for increasing the speed when the object is accelerating

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (objectToControl != null && objectToFollow != null) {
			// Check distance
			float distance = Vector3.Magnitude( objectToControl.transform.position - objectToFollow.transform.position );
			if( distance <= trackDistance ){
				if (distance > maxDistance) {
					moveSpeed = Mathf.Min ((moveSpeed + velocityStep) * distance / trackDistance, maxSpeed);	// adjust speed when object is close
				}else{
					moveSpeed = 0f;
				}
			}

			// move
			objectToControl.transform.Translate (
				Vector3.forward * moveSpeed * Time.deltaTime
			);
		}
	}
}
