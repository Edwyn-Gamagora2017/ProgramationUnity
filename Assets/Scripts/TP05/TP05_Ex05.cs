using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP05_Ex05 : MonoBehaviour {

	[SerializeField]
	Transform objectToSave;

	// Use this for initialization
	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			this.save ();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			this.load ();
		}
	}

	void OnApplicationQuit(){
		this.save ();
	}

	public void save(){
		if (objectToSave != null) {
			TP05_Ex05_Class pos = new TP05_Ex05_Class( objectToSave.position );
			string objectString = JsonUtility.ToJson ( pos );
			System.IO.StreamWriter writer = new System.IO.StreamWriter ( Application.dataPath + "\\savedFiles\\TP05_05.json" );
			if (writer != null) {
				Debug.Log ("WRITE");
				writer.WriteLine ( objectString );
				writer.Close ();
			}
		}
	}

	public void load(){
		try{
			System.IO.StreamReader reader = new System.IO.StreamReader ( Application.dataPath + "\\savedFiles\\TP05_05.json" );

			Debug.Log ("READ");
			string objectString = reader.ReadLine ();

			TP05_Ex05_Class info = JsonUtility.FromJson<TP05_Ex05_Class> (objectString);
			objectToSave.position = new Vector3( info.pos.x, info.pos.y, info.pos.z );

			reader.Close ();
		}
		catch( System.Exception ex ){
			Debug.Log ("No file has been saved or its format is incorrect.");
		}
	}
}
