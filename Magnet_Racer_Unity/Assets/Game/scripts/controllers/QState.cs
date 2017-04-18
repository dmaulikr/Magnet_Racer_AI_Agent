using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QState{

    // Use to determine Quadrant!
    private static float y1_slope = 0.30f;
	private static float y_const = 1.25f;
	private static float y2_slope = -0.60f;

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

	public QState getQState(GameObject magnet, GameObject[] opponents) {
        // TODO: implement. May need to add parameters
        // Determine and set the 5 variables below based on positions and charges
      
        Vector2 position = magnet.GetComponent<Magnet>().getPosition();
        float x = position.x;
        float y = position.y;

        int charge = magnet.GetComponent<Magnet>().getCharge();

        int quadrant = getQuadrant(x,y);


        float distances, closest = float.MaxValue, xOpponent, yOpponent;
        int locked = 0, dir;

        for (int i = 0; i < 3; i++)
            {
                distances = Vector2.Distance(magnet.transform.position, opponents[i].transform.position);
            
                if (closest <= distances)
                {
                    closest = distances;
                    locked = i;
                }
            }

        int distance = (int) closest;


            xOpponent = opponents[locked].transform.position.x;
            yOpponent = opponents[locked].transform.position.y;
            //simplified directions based on which quadrant the closest opponent is present
            if (xOpponent > 0)
            {
                if (yOpponent > 0)
                    dir = 0; //when the opponent is in +x,+y
                else
                    dir = 3; //when the opponent is in +x,-y
            }
            else
            {
                if (yOpponent > 0)
                    dir = 1; //when the opponent is in  -x,+y
                else
                    dir = 2; //when the opponent is in -x,-y
            }

        int direction = dir; //simplified directions based on which quadrant the closest opponent is present

		int otherCharge = opponents[locked].GetComponent<Magnet>().getCharge();

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
    
	/*
	 * Return 0 - 3 based on position in relation to quadrant lines y1 and y2.
	 */ 
	private int getQuadrant(float x, float y) {
        
        
               
        //If above y1
        if (y > (y1_slope * x) + y_const)
        {
            //If above y2
            if (y > (y2_slope * x) + y_const)
            {
                //In zone 1 gives 
                return 0;
            }
            //If below y2
            else
            {
                //In zone 4 gives
                return 3;
            }
        }
        //If below y1
        else
        {
            //If above y2
            if (y > (y2_slope * x) + y_const)
            {
                //In zone 2 gives
                return 1;

            }
            //If below y2
            else
            {
                //In zone 3
                return 2;
            }
        }

    }
}
