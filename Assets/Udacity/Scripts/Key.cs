﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject objectToCreate;
	public Door Door;

	//Create a reference to the KeyPoofPrefab and Door

	void Update()
	{
		transform.position = new Vector3 (0, 2 + Mathf.Sin (Time.time * 5.0f), 37);
		
		//You can use this code to make the key float

		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{

		Object.Instantiate (objectToCreate, new Vector3 (0, 1, 37), Quaternion.identity);
		Destroy (gameObject);
		Door.Unlock ();
		//KeyCollected = true

        // Instatiate the KeyPoof Prefab where this key is located √
        // Make sure the poof animates vertically √
        // Call the Unlock() method on the Door 
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
    }

}
