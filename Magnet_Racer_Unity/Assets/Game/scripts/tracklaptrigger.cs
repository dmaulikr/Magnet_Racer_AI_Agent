using UnityEngine;
using System.Collections;

public class TracklapTrigger : MonoBehaviour
{

    // next trigger in the lap
    public tracklaptrigger next;

    // when an object enters this trigger
    void OnTriggerEnter2D(Collider2D other)
    {
      
        lapcounter carLapCounter = other.gameObject.GetComponent<lapcounter>();
        
        if (carLapCounter)
        {
            Debug.Log("lap trigger " + gameObject.name);
            carLapCounter.OnLapTrigger(this);
            
           
        }
    }
}