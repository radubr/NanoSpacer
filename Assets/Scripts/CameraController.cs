using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject player;
	
	private Vector3 offset;

	public float minFov = 10f;
	public float maxFov = 150f;
	public float sensitivity = 15f;
	public float fov;

	public float horizontalSpeed = 10.0f;
	public float verticalSpeed = 10.0f;
	public float h;
	public float v;
 

	void Start ()
	{
		offset = transform.position - player.transform.position;
	}

	// The camera follows the player and
	// zoom in and out with mouse scroll wheel
	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;

		fov = Camera.main.fieldOfView;
		fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
		fov = Mathf.Clamp(fov, minFov, maxFov);
		Camera.main.fieldOfView = fov;
		while (Input.GetMouseButtonDown(1)) {
			h = horizontalSpeed * Input.GetAxis ("Mouse Y");
			v = verticalSpeed * Input.GetAxis ("Mouse X");
			transform.Translate(v,h,0);
		}


	}



}

