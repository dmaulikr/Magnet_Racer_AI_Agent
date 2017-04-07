using UnityEngine;
using System.Collections;

public class magnetscript : manageforce
{

    
    public GameObject repel;
    public GameObject repel2;
    public GameObject repel3;
    public GameObject repel4;
    public GameObject repel5;
    public GameObject repel6;
    public GameObject repel7;

    // local charges to hold value of each individual racer charge changes
    float thisCharge;
    float otherCharge1;
    float otherCharge2;
    float otherCharge3;

    public float repelling = 1000;
    public float repelling2 = 500;

    public bool done;

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
        //updating value of this charge and the other charges
        switch(gameObject.tag)
        {
            case "RED": thisCharge = charge1;
                        otherCharge1 = charge2;
                        otherCharge2 = charge3;
                        otherCharge3 = charge4;
                        break;
            case "PURPLE": thisCharge = charge2;
                           otherCharge1 = charge1;
                           otherCharge2 = charge3;
                           otherCharge3 = charge4;
                           break;
            case "GREEN": thisCharge = charge3;
                          otherCharge1 = charge1;
                          otherCharge2 = charge2;
                          otherCharge3 = charge4;
                          break;
            case "BLUE": thisCharge = charge4;
                         otherCharge1 = charge1;
                         otherCharge2 = charge2;
                         otherCharge3 = charge3;
                         break;
        }

        //updating sprite of this charge
        
            if (thisCharge == 1)
                spriterender.sprite = spritepositive;
            else if (thisCharge == -1)
                spriterender.sprite = spritenegative;
    }
   
    void FixedUpdate()
    {
      
        updatecharge();
        
        if(myrigidbody.isKinematic == true)
        {
            
            done = true;
        }

		/*
		 * Permanent magnet 1
		 */
        Vector3 direction1 = (transform.position - repel.transform.position).normalized;
        float traveldistance1 = Vector3.Distance(transform.position, repel.transform.position);

        float force1 = repelling / traveldistance1;

        Vector3 newforce1 = direction1 * force1 * thisCharge * polecharge * Time.smoothDeltaTime;

        if (traveldistance1 <= 14)
            myrigidbody.AddForce(newforce1);
		
		/*
		 * Permanent magnet 2
		 */
        Vector3 direction2 = (transform.position - repel2.transform.position).normalized;
        float traveldistance2 = Vector3.Distance(transform.position, repel2.transform.position);

        float force2 = repelling / traveldistance2;

        Vector3 newforce2 = direction2 * force2 * thisCharge * -polecharge * Time.smoothDeltaTime;

        if (traveldistance2 <= 14)
            myrigidbody.AddForce(newforce2);

		/*
		 * Permanent magnet 3
		 */
        Vector3 direction3 = (transform.position - repel3.transform.position).normalized;
        float traveldistance3 = Vector3.Distance(transform.position, repel3.transform.position);

        float force3 = repelling / traveldistance3;

        Vector3 newforce3 = direction3 * force3 * thisCharge * polecharge * Time.smoothDeltaTime;

        if (traveldistance3 <= 14)
            myrigidbody.AddForce(newforce3);


		/*
		 * Permanent magnet 4
		 */
        Vector3 direction4 = (transform.position - repel4.transform.position).normalized;
        float traveldistance4 = Vector3.Distance(transform.position, repel4.transform.position);

        float force4 = repelling / traveldistance4;

        Vector3 newforce4 = direction4 * force4 * thisCharge * -polecharge * Time.smoothDeltaTime;

        if (traveldistance4 <= 14)
            myrigidbody.AddForce(newforce4);
       
		/*
		 * Racer1
		 */
        Vector3 direction5 = (transform.position - repel5.transform.position).normalized;
        float traveldistance5 = Vector3.Distance(transform.position, repel5.transform.position);

        float force5 = repelling2 / traveldistance5;

        Vector3 newforce5 = direction5 * force5 * thisCharge * otherCharge1 * Time.smoothDeltaTime;

        if (traveldistance5 <= 4)
            myrigidbody.AddForce(newforce5);


		/*
		 * Racer2
		 */
        Vector3 direction6 = (transform.position - repel6.transform.position).normalized;
        float traveldistance6 = Vector3.Distance(transform.position, repel6.transform.position);

        float force6 = repelling2 / traveldistance6;

        Vector3 newforce6 = direction6 * force6 * thisCharge * otherCharge2 * Time.smoothDeltaTime;

        if (traveldistance6 <= 4)
            myrigidbody.AddForce(newforce6);

		/*
		 * Racer3
		 */
        Vector3 direction7 = (transform.position - repel7.transform.position).normalized;
        float traveldistance7 = Vector3.Distance(transform.position, repel7.transform.position);

        float force7 = repelling2 / traveldistance7;

        Vector3 newforce7 = direction7 * force7 * thisCharge * otherCharge3 * Time.smoothDeltaTime;

        if (traveldistance7 <= 4)
            myrigidbody.AddForce(newforce7);

    }


}


   

        