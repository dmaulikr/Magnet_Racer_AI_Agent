using UnityEngine;
using System.Collections;

public class lapcounter : MonoBehaviour
{

    public tracklaptrigger first;
    public TextMesh textMesh;
    public TextMesh textMesh2;
    public TextMesh textMesh3;


    public bool win = false;
    public bool second = false;
    public bool third = false;

    

    tracklaptrigger next;
    tracklaptrigger winning;

    GameObject thePlayer ;
    GameObject thePlayer2 ;
    GameObject thePlayer3 ;
    GameObject thePlayer4 ;

    Rigidbody2D rb;
    Rigidbody2D rb2;
    Rigidbody2D rb3;
    Rigidbody2D rb4;

   
    int _lap;
   

    // Use this for initialization
    void Start()
    {
       
        _lap = 0;
        SetNextTrigger(first);
        UpdateText();
        
    }


    // update lap counter text
    void UpdateText()
    {
        if (textMesh)
        {
           textMesh.text = string.Format("{0}", _lap);
        }
    }

    public void winner()
    {
       

        if (textMesh2)
        {
            // printing and finishing each racers control when they cross finish line
            if (_lap == 5 )
                {
                
                textMesh2.text = string.Format("Way to go " + gameObject.name);

                if (gameObject.name == "BLUE")
                {
                    textMesh2.color = Color.blue;
                    win = true;
                }
                else
                 if (gameObject.name == "RED")
                {
                    textMesh2.color = Color.red;
                    win = true;
                }
                else
                 if (gameObject.name == "GREEN")
                {
                    textMesh2.color = Color.green;
                    win = true;
                }
                else
                 if (gameObject.name == "PURPLE")
                {
                    textMesh2.color = Color.magenta;
                    win = true;
                }
                GetComponent<Rigidbody2D>().isKinematic = true;
            }
        }
    


    }

    // when lap trigger is entered
    public void OnLapTrigger(tracklaptrigger trigger)
    {
        
        if (trigger == next)
        {
            if (first == next)
            {
                _lap++;
                UpdateText();
                winner();
            }
            SetNextTrigger(next);
        }
    }

    //adding the next lap trigger counter into
    void SetNextTrigger(tracklaptrigger trigger)
    {

        next = trigger.next;
     
        Debug.Log("next=" +next.gameObject.name);
    }

  
}