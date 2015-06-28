using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MedicineInsideOptions : MonoBehaviour {
	
	public Text countText;
	public Text winText;
	private int count;
	public float medicineStatus;
	
	// Initial variables and function states
	// Medicine is not used (0)
	// Number of catched blood cells is 0 (count)
	// Show the count number of cells
	// Set the win text at the end
	
	void Start () {
		medicineStatus = 0;
		count = 0;
		SetCountText ();
		winText.text = "";
		
	}
	
	// Activate or dezactivate the medicine on space key
	void Update () {
		
		if (Input.GetKeyDown ("space")) {
			
			if (medicineStatus == 0) {
				transform.Translate (0, -0.8f, 0);
				medicineStatus = 1;
			}
			else if (medicineStatus == 1){
				transform.Translate (0, +0.8f, 0);
				medicineStatus = 0;
			}
		}
		
	}
	

	void OnTriggerEnter(Collider other) 
	{
		// When the medicine touches another cell then change it's color
		// to black and update the count number
		if (other.gameObject.CompareTag ("BloodCell"))
		{
			other.gameObject.GetComponent<Renderer>().material.color = Color.black;
			// untag the cell so it avoids counting
			other.gameObject.tag = "Untagged";
			count = count + 1;
			SetCountText ();
		}
		// When the medicine touches the enemy the game ends (lose) beacuse the count number (score)
		// is updated to -1
		if (other.gameObject.CompareTag ("Enemy"))
		{
			other.gameObject.GetComponent<Renderer>().material.color = Color.black;
			// untag the enemy so it avoids counting 
			other.gameObject.tag = "Untagged";
			count = count - 1;
			SetCountText ();
		}
	}

 
	
	// Show the count text, update it and the win/lose text
	void SetCountText ()
	{	// win if score is 3 (all cells are collected)
		countText.text = "Score: " + count.ToString () + " / 3";
		if (count >= 3) {
			winText.color = Color.green;
			winText.text = "You saved me!";
			Time.timeScale = 0;
		} 
		// lose if score is -1 (enemy cell was touched)
		else if (count < 0) {
			winText.color = Color.red;
			winText.text = "You killed me!";
			Time.timeScale = 0;
		}
	}
	
}