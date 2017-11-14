using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP05_Ex04_Class {

	private float maxSpeed;				// max speed of the object to control
	private float velocityStep;			// step for increasing the speed when the object is accelerating
	private float trackDistance;		// Minimun distance necessary to follow the object

	// Standard Values
	private const float basic_maxSpeed = 2f;				// max speed of the object to control
	private const float basic_velocityStep = 0.3f;			// step for increasing the speed when the object is accelerating
	private const float basic_trackDistance = 4f;			// Minimun distance necessary to follow the object

	public TP05_Ex04_Class( float maxSpeedFactor, float velocityStepFactor, float trackDistanceFactor ){
		this.trackDistance = trackDistanceFactor * basic_trackDistance;
		this.velocityStep = velocityStepFactor * basic_velocityStep;
		this.maxSpeed = maxSpeedFactor * basic_maxSpeed;
	}

	public static TP05_Ex04_Class byType( TP05_Ex04_PNJ.PNJ_Type type ){
		switch (type) {
		case TP05_Ex04_PNJ.PNJ_Type.HighAcceleration:
			return new TP05_Ex04_Class (1, 2, 1);
		case TP05_Ex04_PNJ.PNJ_Type.HighSpeed:
			return new TP05_Ex04_Class (2, 1, 1);
		case TP05_Ex04_PNJ.PNJ_Type.HighDistance:
			return new TP05_Ex04_Class (1, 1, 2);
		case TP05_Ex04_PNJ.PNJ_Type.Normal:
		default:
			return new TP05_Ex04_Class (1, 1, 1);
		}
	}

	public float getMaxSpeed(){
		return this.maxSpeed;
	}
	public float getVelocityStep(){
		return this.velocityStep;
	}
	public float getTrackDistance(){
		return this.trackDistance;
	}
}
