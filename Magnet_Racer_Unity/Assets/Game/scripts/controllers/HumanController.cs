using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour {

	private Magnet magnetScript;

    void Start()
    {
		magnetScript = GetComponent<Magnet>();
    }

    // Update is called once per frame
    void Update () {
		
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            magnetScript.makeMove();
        }
	}
}
