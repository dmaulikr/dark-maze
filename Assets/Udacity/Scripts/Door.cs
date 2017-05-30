using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public AudioClip lockeddoor;
	public AudioClip opendoor;

	public AudioSource audio;

	bool locked;
	bool opening;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() √
    // Create a boolean value called "opening" that can be checked in Update()  √

	void Start() {
		locked = true;
		opening = false;
	} 

    void Update() {
        
		if (opening == true) {
			transform.Translate (0, 25.0f * Time.deltaTime, 0, Space.World);
			audio = GetComponent<AudioSource> ();
			audio.clip = opendoor;
			audio.Play ();
			if (transform.position.y >= 9f)
				opening = false;
		}
			
		// If the door is opening and it is not fully raised
            // Animate the door raising up
    }

    public void OnDoorClicked() {

		if (locked == false) {
			opening = true;
		}
		else if (locked == true){
			audio = GetComponent<AudioSource> ();
			audio.clip = lockeddoor;
			audio.Play ();
		}

			
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
		locked = false;
		Debug.Log ("You have unlocked!");
        // You'll need to set "locked" to false here
    }
}
