using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHighlight : MonoBehaviour {

	public GUISkin GameSkin;
	public string objectName;

	private bool _displayObjectName = false;
    private int temp;

	void OnGUI(){
		GUI.skin = GameSkin;
		DisplayName ();
	}

	/*void OnMouseEnter(){
		_displayObjectName = true;
	}

	void OnMouseExit(){
		_displayObjectName = false;
	}*/

	public void DisplayName(){
		if (_displayObjectName) {
            
			string texto = objectName + "\nTempertura: " + temp + " °C";
			GUI.Box (new Rect (50, 50, 400, 100), texto, "box");
		}
	}

	void OnMouseDown(){
		Debug.Log ("Hiciste click");
        temp = Mathf.FloorToInt(Random.Range(40, 100));
		_displayObjectName = !_displayObjectName;
	}
}
