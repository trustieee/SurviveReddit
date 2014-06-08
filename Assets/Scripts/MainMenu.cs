using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void Start(){

		Screen.showCursor = true;

		}

	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect((Screen.width / 2) - 45 ,(Screen.height / 2) - 45,100,90), "Main Menu");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect((Screen.width / 2) - 35,(Screen.height / 2) - 20,80,20), "Start Game")) {
			Application.LoadLevel(1);
		}
		
		// Make the second button.
		if(GUI.Button(new Rect((Screen.width / 2) - 35,(Screen.height / 2) + 10,80,20), "Quit Game")) {
			Application.Quit();
		}
	}
}
