using UnityEngine;
using System.Collections;

public class TruePlayerOptions : MonoBehaviour {
	
 
	
	void Start ()
	{
 
	}
	
	void Update () {
		
		
		

		if (Input.GetKeyDown ("d")) {
			transform.Translate (+0.5f, 0, 0);
			
		}
		if (Input.GetKeyDown ("a")) {
			transform.Translate (-0.5f, 0, 0);
			
		}
		if (Input.GetKeyDown ("q")) {
			transform.Translate (0, -0.5f, 0);
			
		}
		if (Input.GetKeyDown ("e")) {
			transform.Translate (0, +0.5f, 0);
			
		}
		if (Input.GetKeyDown ("s")) {
			transform.Translate (0, 0, -0.5f);
			
		}
		if (Input.GetKeyDown ("w")) {
			transform.Translate (0, 0, +0.5f);
			
		}
		if (Input.GetKeyDown ("z")) {
			transform.Rotate(Vector3.right * Time.deltaTime * 10);
			transform.Rotate(Vector3.up * Time.deltaTime * 10, Space.World);
			
		}
		if (Input.GetKeyDown ("x")) {
			transform.Translate (0, 0, +0.8f);
			
		}
	}
 


}