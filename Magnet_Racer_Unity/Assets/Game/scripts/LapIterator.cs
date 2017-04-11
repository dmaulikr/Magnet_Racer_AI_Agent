using UnityEngine;
using System.Collections;

public class LapIterator : MonoBehaviour
{

    public GateTrigger currentLapTrigger;
	public TextMesh lapCountText;

    bool win = false;

	GateTrigger nextLapTrigger;
	GateTrigger winning;

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
        if (_lap == 1)
        {
            GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }

    // when lap trigger is entered
	public void OnLapTrigger(GateTrigger trigger)
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
	void SetNextTrigger(GateTrigger trigger)
    {
        nextLapTrigger = trigger.next;
     
        Debug.Log("next=" + nextLapTrigger.gameObject.name);
    }
}