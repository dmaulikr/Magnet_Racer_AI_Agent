﻿using UnityEngine;
using System.Collections;

public class LapCounter : MonoBehaviour
{

    public TrackLapTrigger currentLapTrigger;
	public TextMesh lapCountText;

    bool win = false;

	TrackLapTrigger nextLapTrigger;
	TrackLapTrigger winning;

    int _lap;
   
    // Use this for initialization
    void Start()
    {
        _lap = 0;
		SetNextTrigger(currentLapTrigger);
        UpdateText();
    }


    // Update lap counter text
    void UpdateText()
    {
		if (lapCountText)
        {
			lapCountText.text = string.Format("{0}", _lap);
        }
    }

	// Check for a winner
    public void winner()
    {
        if (_lap == 5)
        {
			win = true;
            GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }

    // when lap trigger is entered
	public void OnLapTrigger(TrackLapTrigger trigger)
    {
        if (trigger == nextLapTrigger)
        {
			if (currentLapTrigger == nextLapTrigger)
            {
                _lap++;
                UpdateText();
                winner();
            }
            SetNextTrigger(nextLapTrigger);
        }
    }

    //adding the next lap trigger counter into
	void SetNextTrigger(TrackLapTrigger trigger)
    {
        nextLapTrigger = trigger.next;
     
        Debug.Log("next=" + nextLapTrigger.gameObject.name);
    }
}