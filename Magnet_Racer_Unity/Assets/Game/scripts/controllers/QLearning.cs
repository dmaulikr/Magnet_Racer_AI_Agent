using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QLearning : MonoBehaviour {

	// Location of q map text file
	public string qMapFileLocation;

	// Game objects to use
	private GameObject magnet;
	private GameObject[] opponents;

	// Parents magnet script
	private Magnet magnetScript;

	// QMap for stored q values
	private QMap qMap;

	void Start() {
		magnet = gameObject;
		magnetScript = magnet.GetComponent<Magnet> ();
		opponents = magnetScript.getOpponents ();
		qMap = new QMap (qMapFileLocation);
	}

	// If deciding to toggle, call magnet scripts toggle functionality.
	void FixedUpdate () {

		if (false) {
			magnetScript.makeMove ();
		}
	}
}
