using UnityEngine;
using System.Collections;

public class magnetscript3 : manageforce
{


    public GameObject repel;
    public GameObject repel2;
    public GameObject repel3;
    public GameObject repel4;
    public GameObject repel5;
    public GameObject repel6;
    public GameObject repel7;
    public float repelling = 1000;
    public float repelling2 = 500;

    public bool done3;


    public Sprite spritepositive;
    public Sprite spritenegative;
    SpriteRenderer spriterender;

    Rigidbody2D myrigidbody;

    void Start()
    {
        spriterender = GetComponent<SpriteRenderer>();
        updatecharge();

        myrigidbody = GetComponent<Rigidbody2D>();
    }

    public void updatecharge()
    {
        if (charge3 == 1)
            spriterender.sprite = spritepositive;
        else if (charge3 == -1)
            spriterender.sprite = spritenegative;
    }

    public void updatecolor()
    {
        //Debug.Log("works");
        Color color = charge3 > 0 ? Color.green : Color.red;
        GetComponent<Renderer>().material.color = color;
    }

    void FixedUpdate()
    {
        //updatecolor();
        updatecharge();
        if (myrigidbody.isKinematic == true)
        {
            done3 = true;
        }

		/*
		 * Permanent magnet 1
		 */
        Vector3 direction1 = (transform.position - repel.transform.position).normalized;
        float traveldistance1 = Vector3.Distance(transform.position, repel.transform.position);

        float force1 = repelling / traveldistance1;

        Vector3 newforce1 = direction1 * force1 * charge3 * polecharge * Time.smoothDeltaTime;

        if (traveldistance1 <= 13)
            myrigidbody.AddForce(newforce1);


		/*
		 * Permanent magnet 2
		 */
        Vector3 direction2 = (transform.position - repel2.transform.position).normalized;
        float traveldistance2 = Vector3.Distance(transform.position, repel2.transform.position);

        float force2 = repelling / traveldistance2;

        Vector3 newforce2 = direction2 * force2 * charge3 * -polecharge * Time.smoothDeltaTime;

        if (traveldistance2 <= 13)
            myrigidbody.AddForce(newforce2);


		/*
		 * Permanent magnet 3
		 */
        Vector3 direction3 = (transform.position - repel3.transform.position).normalized;
        float traveldistance3 = Vector3.Distance(transform.position, repel3.transform.position);

        float force3 = repelling / traveldistance3;

        Vector3 newforce3 = direction3 * force3 * charge3 * polecharge * Time.smoothDeltaTime;

        if (traveldistance3 <= 13)
            myrigidbody.AddForce(newforce3);


		/*
		 * Permanent magnet 4
		 */
        Vector3 direction4 = (transform.position - repel4.transform.position).normalized;
        float traveldistance4 = Vector3.Distance(transform.position, repel4.transform.position);

        float force4 = repelling / traveldistance4;

        Vector3 newforce4 = direction4 * force4 * charge3 * -polecharge * Time.smoothDeltaTime;

        if (traveldistance4 <= 13)
            myrigidbody.AddForce(newforce4);


		/*
		 * Racer 1
		 */ 
        Vector3 direction5 = (transform.position - repel5.transform.position).normalized;
        float traveldistance5 = Vector3.Distance(transform.position, repel5.transform.position);

        float force5 = repelling2 / traveldistance5;

        Vector3 newforce5 = direction5 * force5 * charge3 * charge1 * Time.smoothDeltaTime;

        if (traveldistance5 <= 4)
            myrigidbody.AddForce(newforce5);

		/*
		 * Racer 2
		 */ 
        Vector3 direction6 = (transform.position - repel6.transform.position).normalized;
        float traveldistance6 = Vector3.Distance(transform.position, repel6.transform.position);

        float force6 = repelling2 / traveldistance6;

        Vector3 newforce6 = direction6 * force6 * charge3 * charge2 * Time.smoothDeltaTime;

        if (traveldistance6 <= 4)
            myrigidbody.AddForce(newforce6);



		/*
		 * Racer 3
		 */
        Vector3 direction7 = (transform.position - repel7.transform.position).normalized;
        float traveldistance7 = Vector3.Distance(transform.position, repel7.transform.position);

        float force7 = repelling2 / traveldistance7;

        Vector3 newforce7 = direction7 * force7 * charge3 * charge4 * Time.smoothDeltaTime;

        if (traveldistance7 <= 4)
            myrigidbody.AddForce(newforce7);
    }
}





