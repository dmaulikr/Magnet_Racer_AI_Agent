using UnityEngine;
using System.Collections;

public class TrackLapTrigger : MonoBehaviour
{

    // next trigger in the lap
    public TrackLapTrigger next;

    // when an object enters this trigger
    void OnTriggerEnter2D(Collider2D other)
    {
      
        LapCounter carLapCounter = other.gameObject.GetComponent<LapCounter>();
        
        if (carLapCounter)
        {
            Debug.Log("lap trigger " + gameObject.name);
            carLapCounter.OnLapTrigger(this);
            
           
        }
    }
}