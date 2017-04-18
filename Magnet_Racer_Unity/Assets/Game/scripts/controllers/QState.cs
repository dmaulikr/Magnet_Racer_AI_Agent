using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QState {

	// 0 or 1
	private int thisCharge;

	// 0, 1, 2, 3
	private int thisQuadrant;

	// 1, 2 ... 4 (May change.)
	private int nearestOpponentDistance;

	// every 90 degrees
	private int nearestOpponentDirection;

	// 0 or 1
	private int nearestOpponentCharge;

	public QState() {
		thisCharge = 0;
		thisQuadrant = 0;
		nearestOpponentDistance = 0;
		nearestOpponentDirection = 0;
		nearestOpponentCharge = 0;
	}

	public QState(int charge, int quadrant, int distance, int direction, int otherCharge) {
		thisCharge = charge;
		thisQuadrant = quadrant;
		nearestOpponentDistance = distance;
		nearestOpponentDirection = direction;
		nearestOpponentCharge = otherCharge;
	}

	public static QState getQState() {
		// TODO: implement. May need to add parameters
		int charge = 0;
		int quadrant = 0;
		int distance = 0;
		int direction = 0;
		int otherCharge = 0;

		return new QState(charge, quadrant, distance, direction, otherCharge);
	}


	// Override equals for comparisons we want.
	public override bool Equals(object obj)
	{
		var item = obj as QState;

		if (item == null)
		{
			return false;
		}

		return this.GetHashCode() == item.GetHashCode();
	}

	// Override hash code for comparisons
	public override int GetHashCode()
	{
		return thisCharge * 10000 + thisQuadrant * 1000 + nearestOpponentDistance * 100 + 
			nearestOpponentDirection * 10 + nearestOpponentCharge;
	}
}
