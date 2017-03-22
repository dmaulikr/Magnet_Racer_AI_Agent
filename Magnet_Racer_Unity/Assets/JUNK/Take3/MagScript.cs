using UnityEngine;
using System.Collections;

public class MagScript : manageforce {

    //public GameObject attract;
    public GameObject repel;
    public float repelling = 1000;
    // public float attracting = 1000;
   // public float charge1 = 1;
    Rigidbody2D myrigidbody;

    void Start()
    {

        myrigidbody = GetComponent<Rigidbody2D>();
        updatecolor1();
    }

    public void updatecolor1()
    {
        //Debug.Log("works");
        Color color = polecharge > 0 ? Color.green : Color.red;
        GetComponent<Renderer>().material.color = color;
    }


    void Update()
            {


        updatecolor1();
        // Vector2 positionmagnet=transform.position;
        //Vector3 direction = (transform.position - attract.transform.position).normalized;
        Vector3 directionrepel = (transform.position - repel.transform.position).normalized;

        //  float traveldistance = Vector3.Distance(transform.position, attract.transform.position);
        float traveldistancerepel = Vector3.Distance(transform.position, repel.transform.position);

        //float force = (attracting ) / traveldistance;
        float forcerepel = repelling / traveldistancerepel;

        //Vector3 newforce = -direction * force *charge* Time.smoothDeltaTime;
        Vector3 newforcerepel = directionrepel * forcerepel * polecharge *charge1* Time.smoothDeltaTime;

        //if (traveldistance <= 2)
        //{
        //  myrigidbody.velocity = newforce;
        //}
        if (traveldistancerepel <= 3)
            myrigidbody.AddForce(newforcerepel);

        // if (traveldistance < 1 || traveldistance > 3)
        {
            //   myrigidbody.velocity = Vector3.zero;
            //Debug.Log("works?");
        }
          if (traveldistancerepel < 1 )
        {
          myrigidbody.velocity = Vector3.zero;
          myrigidbody.AddForce(Vector3.zero);
   }


        //rigidbody2D.velocity = -direction * travelSpeed; 
    }

}

