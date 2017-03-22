﻿using UnityEngine;
using System.Collections;

public class manageforce : MonoBehaviour
{
    public AudioSource switch_sound = null;
  

    public TextMesh textmesh;
    public TextMesh textmesh2;
    public TextMesh textmesh3;
    public TextMesh textmesh4;


    public float charge1 = 1;
    public float charge2 = 1;
    public float charge3 = 1;
    public float charge4 = 1;
    public float polecharge;

    int count;
    bool flag1;
    bool flag2;
    bool flag3;
    bool flag4;

    bool redwin;
    bool redsecond;
    bool redthird;
    bool redfourth;

    bool purplewin;
    bool purplesecond;
    bool purplethird;
    bool purplefourth;

    bool greenwin;
    bool greensecond;
    bool greenthird;
    bool greenfourth;

    bool bluewin;
    bool bluesecond;
    bool bluethird;
    bool bluefourth;
    

    void start()
    {
        count = 0;
        charge1 = GetComponent<float>();
        charge2 = GetComponent<float>();
        charge3 = GetComponent<float>();
        charge4 = GetComponent<float>();
        polecharge = GetComponent<float>();
    }

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
           
            if (polecharge == 1)
                polecharge = -1;
            else if (polecharge == -1)
                polecharge = 1;
        }


        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch_sound.Play();
            if (charge1 == 1)
                charge1 = -1;
            else if (charge1 == -1)
                charge1 = 1;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            switch_sound.Play();
            if (charge2 == 1)
                charge2 = -1;
            else if (charge2 == -1)
                charge2 = 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            switch_sound.Play();
            if (charge3 == 1)
                charge3 = -1;
            else if (charge3 == -1)
                charge3 = 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            switch_sound.Play();
            if (charge4 == 1)
                charge4 = -1;
            else if (charge4 == -1)
                charge4 = 1;
        }


        if ((GameObject.Find("RED").GetComponent<magnetscript>().done == true && flag1 != true)|| (count==3 && flag1!=true))
        {
            Debug.Log("managinglaps" + count);
            if (count == 0)
                redwin = true;
            else if (count == 1)
                redsecond = true;
            else if (count == 2)
                redthird = true;
            else if (count == 3)
                redfourth = true;

            count += 1;
            flag1 = true;
        }
        if ((GameObject.Find("PURPLE").GetComponent<magnetscript2>().done2 == true && flag2 != true)|| (count==3 && flag2!=true))
        {
            Debug.Log("managinglappppp" + count);
            if (count == 0)
                purplewin = true;
            else if (count == 1)
                purplesecond = true;
            else if (count == 2)
                purplethird = true;
            else if (count == 3)
                purplefourth = true;

            count += 1;
            flag2 = true;
        }
        if ((GameObject.Find("GREEN").GetComponent<magnetscript3>().done3 == true && flag3 != true) || (count==3 && flag3 !=true))
        {
            if (count == 0)
                greenwin = true;
            else if (count == 1)
                greensecond = true;
            else if (count == 2)
                greenthird = true;
            else if (count == 3)
                greenfourth = true;

            count += 1;
            flag3 = true;
        }
        if ((GameObject.Find("BLUE").GetComponent<magnetscript4>().done4 == true && flag4 != true) || (count ==3 && flag4!=true))
        {
            if (count == 0)
                bluewin = true;
            else if (count == 1)
                bluesecond = true;
            else if (count == 2)
                bluethird = true;
            else if (count == 3)
                bluefourth = true;

            count += 1;
            flag4 = true;
        }

        if (count == 4)
        {
            if (redwin == true)
                textmesh.text = string.Format("WINNER RED");
            else if (redsecond == true)
                textmesh.text = string.Format("Second RED");
            else if (redthird == true)
                textmesh.text = string.Format("Third RED");
            else if (redfourth == true)
                textmesh.text = string.Format("Fourth RED");

            if (purplewin == true)
                textmesh2.text = string.Format("WINNER PURPLE");
            else if (purplesecond == true)
                textmesh2.text = string.Format("Second PURPLE");
            else if (purplethird == true)
                textmesh2.text = string.Format("Third PURPLE");
            else if (purplefourth == true)
                textmesh2.text = string.Format("Fourth PURPLE");

            if (greenwin == true)
                textmesh3.text = string.Format("WINNER GREEN");
            else if (greensecond == true)
                textmesh3.text = string.Format("Second GREEN");
            else if (greenthird == true)
                textmesh3.text = string.Format("Third GREEN");
            else if (greenfourth == true)
                textmesh3.text = string.Format("Fourth GREEN");

            if (bluewin == true)
                textmesh4.text = string.Format("WINNER BLUE");
            else if (bluesecond == true)
                textmesh4.text = string.Format("Second BLUE");
            else if (bluethird == true)
                textmesh4.text = string.Format("Third BLUE");
            else if (bluefourth == true)
                textmesh4.text = string.Format("Fourth BLUE");

            Time.timeScale = 0;
        }
    }
}

