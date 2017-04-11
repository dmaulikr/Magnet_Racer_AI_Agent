using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionTree : MonoBehaviour {

	private Magnet magnetScript;

	private float y1_slope = 0.446f;
	private float y_const = 1.25f;
	private float y2_slope = -0.486f;

	void Start() {
		magnetScript = GetComponent<Magnet> ();
	}

	//Returns true if you want to toggle
	void Update () {

		float x = magnetScript.gameObject.transform.position.x;
		float y = magnetScript.gameObject.transform.position.y;

		//If above y1
		if (y > (y1_slope*x)+y_const)
		{
			//If above y2
			if (y > (y2_slope*x)+y_const)
			{
				//In zone 1
				if (magnetScript.charge == 1) {
					//Do nothing
					return;
				}
				else 
				{
					//Toggle to positive
					magnetScript.makeMove();
				}
			}
			//If below y2
			else
			{
				//In zone 4
				if (magnetScript.charge == 1) {
					//Toggle to positive
					magnetScript.makeMove();
				}
				else 
				{
					//Do nothing
					return;
				}
			}
		}
		//If below y1
		else
		{
			//If above y2
			if (y > (y2_slope*x)+y_const)
			{
				//In zone 2
				if (magnetScript.charge == 1) {
					//Toggle to positive
					magnetScript.makeMove();
				}
				else 
				{
					//Do nothing
					return;
				}
			}
			//If below y2
			else
			{
				//In zone 3
				if (magnetScript.charge == 1) {
					//Do nothing
					return;
				}
				else 
				{
					//Toggle to positive
					magnetScript.makeMove();
				}
			}
		}


		// Get a random number
		float randomNumber = Random.value;

		// Don't want to toggle too often, so use a probabilty 
		// of 0.02
		if (randomNumber < 0.02) {
			magnetScript.makeMove ();
		}
	}
}
