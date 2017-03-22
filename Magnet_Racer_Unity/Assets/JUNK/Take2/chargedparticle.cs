using UnityEngine;
using System.Collections;

public class chargedparticle : MonoBehaviour {

    public float charge = 1;

    void Start()
    {
        updatecolor();
    }

    public void updatecolor()
    {
        //Debug.Log("works");
        Color color = charge > 0 ? Color.green : Color.red;
        GetComponent<Renderer>().material.color = color;
    }
	
	
}
