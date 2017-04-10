using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * A simple random move agent which provides a true of false
 * value to use when deciding if the polarity of a magnet should 
 * switch.
 */
public class RandomAgent : MonoBehaviour {

	private MagnetScript magnetScript;

	void Start() {
		magnetScript = GetComponent<MagnetScript> ();
	}

	//Returns true if you want to toggle
	void Update () {
		// Get a random number
		float randomNumber = Random.value;

		// Don't want to toggle too often, so use a probabilty 
		// of 0.02
		if (randomNumber < 0.02) {
			magnetScript.makeMove ();
		}
	}
}
