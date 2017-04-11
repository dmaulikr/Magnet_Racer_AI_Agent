using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour {

    private MagnetScript magnetScript;

    void Start()
    {
        magnetScript = GetComponent<MagnetScript>();
    }

    // Update is called once per frame
    void Update () {
		
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            magnetScript.makeMove();
        }
	}
}
