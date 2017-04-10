using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAgent : MonoBehaviour {
	
	//Returns true if you want to toggle
	public bool getDecision () {
		// Get a random number
		float randomNumber = Random.value;

		// Don't want to toggle too often, so use a probabilty 
		// of 0.02
		return randomNumber < 0.02;
	}
}
