using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WeaponController : MonoBehaviour {

	public Text countText;
	public Text winText;
	private int count;
	public float weaponStatus;
	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		weaponStatus = 0;
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	


		if (Input.GetKeyDown ("space")) {

			if (weaponStatus == 0) {
				transform.Translate (0, -0.8f, 0);
			weaponStatus = 1;
			}
			else if (weaponStatus == 1){
				transform.Translate (0, +0.8f, 0);
				weaponStatus = 0;
			}
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("BloodCell"))
		{
			other.gameObject.GetComponent<Renderer>().material.color = Color.black;
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 7)
		{
			winText.text = "You Saved Me!";
			Time.timeScale = 0;
		}
	}
 
}
