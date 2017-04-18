using UnityEngine;
using System.Collections;
using System.IO;

public class LapIterator : MonoBehaviour
{

	// Save data file location
	public string saveLapDataFile;

    public GateTrigger currentLapTrigger;
	public TextMesh lapCountText;
    public GameObject endPoint;
	public int winLapCount;

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
        if (_lap == winLapCount)
        {
            win = true;
			Rigidbody2D rigid = GetComponent<Rigidbody2D> ();
			rigid.transform.position = endPoint.transform.position;
			rigid.transform.rotation = Quaternion.identity;
			rigid.constraints = RigidbodyConstraints2D.FreezeAll;
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


	/*
	 * Allow to analyze effectiveness by saving a magnets lap times to a text file.
	 */
	private void saveLapTimeData() {
		int lapCount = 0;
		int lapTime = 0;
		StreamWriter file = new StreamWriter (saveLapDataFile, true);
		file.WriteLine ("Lap : " + lapCount + " Time: " + lapTime);
		file.Close ();
	}
}