using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public AudioSource switch_sound = null;

	//Magnet Objects
	public GameObject green;
	public GameObject purple;
	public GameObject red;
	public GameObject blue;

	//Variables for the in game texts
    public TextMesh textmesh;
    public TextMesh textmesh2;
    public TextMesh textmesh3;
    public TextMesh textmesh4;

    //Variables for win check
    bool flag1;
    bool flag2;
    bool flag3;
    bool flag4;

	//Variable for counting number of players across finish line
	int count;	

	//Variable for Red's final position check
    bool redwin;
    bool redsecond;
    bool redthird;
    bool redfourth;

	//Variable for Purple's final position check
    bool purplewin;
    bool purplesecond;
    bool purplethird;
    bool purplefourth;

	//Variable for Green's final position check
    bool greenwin;
    bool greensecond;
    bool greenthird;
    bool greenfourth;

	//Variable for Blue's final position check
    bool bluewin;
    bool bluesecond;
    bool bluethird;
    bool bluefourth;

    void start()
    {
        count = 0;
    }

    
    void Update()
    {
		/*
		 * * Counting position of each racer in the end
		 */
        if ((red.GetComponent<MagnetScript>().done == true && flag1 != true)|| (count==3 && flag1!=true))
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
		if ((purple.GetComponent<MagnetScript>().done == true && flag2 != true)|| (count==3 && flag2!=true))
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
		if ((green.GetComponent<MagnetScript>().done == true && flag3 != true) || (count==3 && flag3 !=true))
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
		if ((blue.GetComponent<MagnetScript>().done == true && flag4 != true) || (count ==3 && flag4!=true))
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

		/*
		 * Printing the results on screen when race is finished
		 */
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

