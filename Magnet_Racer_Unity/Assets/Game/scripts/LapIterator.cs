using UnityEngine;
using System.Collections;

public class LapIterator : MonoBehaviour
{

    public GateTrigger currentLapTrigger;
	public TextMesh lapCountText;
    public GameObject endPoint;

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
            win = true;
            GetComponent<Rigidbody2D>().transform.position = endPoint.transform.position;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
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