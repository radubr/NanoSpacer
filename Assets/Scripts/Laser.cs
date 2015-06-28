using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	LineRenderer line;

	void Start () {
	
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = true;

		// hide the mouse cursor
		Cursor.visible = false;
	}
	

	void LateUpdate () {

			StartCoroutine("StartLaser");
	}
	IEnumerator StartLaser()
	{
		//if the laser hits something then stop the ray on the object
		// does not let pass it

		Ray ray = new Ray(transform.position, transform.forward);

		RaycastHit hit;

		line.SetPosition(0, ray.origin);

		if (Physics.Raycast (ray, out hit, 100)) {
			line.SetPosition(1, hit.point);
		} else {
			line.SetPosition(1, ray.GetPoint (100));
		}
			yield return null;
	}
}
