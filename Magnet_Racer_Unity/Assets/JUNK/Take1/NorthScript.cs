using UnityEngine;
using System.Collections;

public class NorthScript : MonoBehaviour
{

    public GameObject attract;
    public GameObject repel;
    public float repelling = 1000;
    public float attracting = 1000;
    public float charge = 1;
    Rigidbody2D myrigidbody;

    void Start()
    {
        updatecolor();
        myrigidbody = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (charge == 1)
                charge = -1;
            else if (charge == -1)
                charge = 1;
            updatecolor();
        }
        // Vector2 positionmagnet=transform.position;
        Vector2 direction = (transform.position - attract.transform.position).normalized;
        // Vector2 directionrepel = (transform.position - repel.transform.position).normalized;

        float traveldistance = Vector2.Distance(transform.position, attract.transform.position);
        //float traveldistancerepel = Vector2.Distance(transform.position, repel.transform.position);

        float force = (attracting * charge) / traveldistance;
        //float forcerepel = repelling / traveldistancerepel;

        Vector2 newforce = -direction * force * Time.smoothDeltaTime;
        //Vector2 newforcerepel = directionrepel * forcerepel * Time.smoothDeltaTime;

        if (traveldistance <= 2)
        {
            myrigidbody.velocity = newforce;
        }
        // if (traveldistancerepel <= 2)
        //  myrigidbody.AddForce(newforcerepel);

        if (traveldistance < 1 || traveldistance > 2)
        {
            myrigidbody.velocity = Vector2.zero;
            Debug.Log("works?");
        }
        //if (traveldistancerepel < 1 || traveldistancerepel > 4)
        //{
        //  myrigidbody.velocity = Vector2.zero;
        //myrigidbody.AddForce(Vector2.zero);
        // }

        //rigidbody2D.velocity = -direction * travelSpeed; 
    }
    public void updatecolor()
    {
        Color color1 = charge > 0 ? Color.red : Color.gray;
        GetComponent<SpriteRenderer>().color = color1;

    }
}
