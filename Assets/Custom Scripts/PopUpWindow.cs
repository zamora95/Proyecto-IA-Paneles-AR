using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PopUpWindow : MonoBehaviour {

	public GameObject window;
	public Text messageField;

	public void Show(string message){
		messageField.text = message;
		window.SetActive (true);
	}

	public void Hide(){
		window.SetActive (false);
	}
}
