using UnityEngine;
using System.Collections;

public class LapCounter : MonoBehaviour
{

    public TrackLapTrigger currentLapTrigger;
    public TextMesh textMesh;
    public TextMesh textMesh2;

    public bool win = false;

	TrackLapTrigger nextLapTrigger;
	TrackLapTrigger winning;

    int _lap;
   
    // Use this for initialization
    void Start()
    {
        _lap = 0;
        SetNextTrigger(first);
        UpdateText();
    }


    // Update lap counter text
    void UpdateText()
    {
        if (textMesh)
        {
           textMesh.text = string.Format("{0}", _lap);
        }
    }

	// Check for a winner
    public void winner()
    {
        if (textMesh2 && _lap == 5)
        {
            
            textMesh2.text = string.Format("Way to go " + gameObject.name);

			switch (gameObject.name) {
				case "BLUE":
					textMesh2.color = Color.blue;
				case "RED":
					textMesh2.color = Color.red;
				case "GREEN":
					textMesh2.color = Color.green;
				default:
					textMesh2.color = Color.magenta;
			}
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