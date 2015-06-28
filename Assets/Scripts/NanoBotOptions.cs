using UnityEngine;
using System.Collections;

public class NanoBotOptions : MonoBehaviour {

	void Start () {

	}
	
	// Keys to press to move the bot full body on X, Y and Z axis

	void Update () {

			// move right on X axis
			if (Input.GetKey ("d")) {
				transform.Translate (+0.1f, 0, 0);
			
			}
			// move left on X axis
			if (Input.GetKey ("a")) {
				transform.Translate (-0.1f, 0, 0);
			
			}
			// move up on Y axis
			if (Input.GetKey ("q")) {
				transform.Translate (0, -0.1f, 0);
			
			}
			// move down on Y axis
			if (Input.GetKey ("e")) {
				transform.Translate (0, +0.1f, 0);
			
			}
			// mode left on Z axis
			if (Input.GetKey ("s")) {
				transform.Translate (0, 0, -0.1f);
			
			}
			// move right on Z axis
			if (Input.GetKey ("w")) {
				transform.Translate (0, 0, +0.1f);
			
			}

	}
}