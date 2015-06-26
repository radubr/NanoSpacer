using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MedicineInsideOptions : MonoBehaviour {

	public Text countText;
	public Text winText;
	private int count;
	public float weaponStatus;

	// Initial variables and function states
	// Weapon is not used (0)
	// Number of catched blood cells is 0 (count)
	// Show the count number of cells
	// Set the win text at the end

	void Start () {
		weaponStatus = 0;
		count = 0;
		SetCountText ();
		winText.text = "";

	}
	
	// Activate or dezactivate the weapon on space key
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

	// When the weapon touches another cell then change it's color
	// to black and update the count number
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("BloodCell"))
		{
			other.gameObject.GetComponent<Renderer>().material.color = Color.black;
			count = count + 1;
			SetCountText ();
		}
	}

	// Show the count text, update it and the win text
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString () + " / 7";
		if (count >= 1)
		{
			winText.text = "You saved me!";
			Time.timeScale = 0;
		}
	}

 
}
