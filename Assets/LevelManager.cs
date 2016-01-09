using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log("Level load requested for: "+name);
		// name could be any scene in the game
		Application.LoadLevel(name);
	}
	
	public void QuitRequest() {
		Debug.Log ("Quit requested to leave game");
		// no effect for debug and web build
		Application.Quit ();
	}
}
