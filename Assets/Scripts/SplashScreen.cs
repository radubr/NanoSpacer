using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Return)) {
			Start2();
		}

	}

 
	void Start2 () {
		Application.LoadLevel ("Main");
 
 
	}
	
 
}
