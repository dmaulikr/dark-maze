using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin1 : MonoBehaviour 
{
	public GameObject objectToCreate;

	//Create a reference to the CoinPoofPrefab

    public void OnCoinClicked() {

		Destroy (gameObject);
		Object.Instantiate (objectToCreate, new Vector3 (20, 2, 99), Quaternion.identity);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    }

}
