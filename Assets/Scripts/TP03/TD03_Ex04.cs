using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD03_Ex04 : MonoBehaviour {

	// Attributes
	[SerializeField]						// SerializeField is used to make the variable visible in the Unity's Inspector, by keeping it private or protected. Another solution is to make the variable public
	private GameObject objectToControl;		// Object to be controlled

	[SerializeField]
	private Color buttonDownColor;			// Color that represents the button Down Event
	[SerializeField]
	private Color buttonPressedColor;		// Color that represents the button Pressed Event
	[SerializeField]
	private Color buttonUpColor;			// Color that represents the button Up Event

	[SerializeField]
	float timeShowButtonDown = 0.1f;		// time while the color for Button Down is presented
	float timeShowCounter = 0f;				// Counter to show key down
	float timePressedCounter = 0f;			// Counter to store the time key is down

	MeshRenderer renderer;					// Renderer

	// Use this for initialization
	void Start () {
		renderer = objectToControl.GetComponent<MeshRenderer> ();
		renderer.material.shader = Shader.Find ("Specular");
	}
	
	// Update is called once per frame
	void Update () {
		if( objectToControl ){
			// Change Color when keypad Enter is pressed
			if( Input.GetKeyDown( KeyCode.KeypadEnter ) ){
				renderer.material.color = buttonDownColor;
				timeShowCounter = timeShowButtonDown;
				timePressedCounter = 0f;
			}
			if( Input.GetKey( KeyCode.KeypadEnter ) ){
				if (timeShowCounter > 0f) {
					timeShowCounter -= Time.deltaTime;
				} else {
					timePressedCounter += Time.deltaTime;
					// Chqnge color bqsed on pressed time
					Color colorPressed = buttonPressedColor;
					colorPressed.r = timePressedCounter/3f;
					renderer.material.color = colorPressed;
				}
			}
			if( Input.GetKeyUp( KeyCode.KeypadEnter ) ){
				renderer.material.color = buttonUpColor;
			}
		}
	}
}
