using UnityEngine;
using System.Collections;

public class managelaps1 : MonoBehaviour
{ int count;
    bool flag1;
    bool flag2;
    bool flag3;
    bool flag4;
    void Start()
    {
        count = 0;
    }
    void Update()
    {
        if (GameObject.Find("RED").GetComponent<magnetscript>().done == true && flag1 != true)
        {
            Debug.Log("managinglaps"+count);

            count += 1;
            flag1 = true;
        }
        if (GameObject.Find("PURPLE").GetComponent<magnetscript>().done == true && flag2!=true)
        {
            Debug.Log("managinglappppp" + count);
            count += 1;
            flag2 = true;
        }
        if (GameObject.Find("GREEN").GetComponent<magnetscript>().done == true && flag3!=true)
        {
            count += 1;
            flag3 = true;
        }
        if (GameObject.Find("BLUE").GetComponent<magnetscript>().done == true && flag4!=true)
        {
            count += 1;
            flag4 = true;
        }

       // if (count == 4)
        //    Application.LoadLevel(1);
    }
}
