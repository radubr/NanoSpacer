using UnityEngine;
using System.Collections;

public class ArmAndPayload : MonoBehaviour {

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	
	private Rigidbody rb;

	public float horizontalSpeed = 10.0F;
	public float verticalSpeed = 10.0F;
 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
 
	void Update() {
		//mouse movement
		float h = horizontalSpeed * Input.GetAxis("Mouse X");
		float v = verticalSpeed * Input.GetAxis("Mouse Y");
		transform.Rotate(v, h, 0);

		//keyboard movement
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
	}
}
