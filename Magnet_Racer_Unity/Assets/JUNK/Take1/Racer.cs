using UnityEngine;
using System.Collections;

public class Racer : MonoBehaviour {
    public float Speed = 1000;
    //Vector2 position;
   private bool flag= false;
    private Rigidbody2D rb;


    void Start()
    {
        // position = transform.position;
        rb = GetComponent<Rigidbody2D>();

    }

    void OnGUI()
    {
        if(flag == true)
        GUI.Label(new Rect(10, 10, 100, 20), "WINNER!");
    }

    void Update()
      { 

        /*
            position.x += Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
            position.y += Input.GetAxis("Vertical") * Speed * Time.deltaTime;
           
            transform.position = position;
          */

        if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.AddForce(-Vector2.up * Speed);
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.zero);
        }   

        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddForce(Vector2.up * Speed);
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.zero);
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.AddForce(-Vector2.right * Speed);
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.zero);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.AddForce(Vector2.right * Speed);
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.zero);
        }



    }

    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("yogo");

        if (other.gameObject.CompareTag("Finish"))
        {
            flag = true;
        }
        if (other.gameObject.CompareTag("speed"))
        {
            Speed = 20000;
        }
        if (other.gameObject.CompareTag("slow"))
        {
            Speed = 500;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("speed")|| other.gameObject.CompareTag("slow"))
            Speed = 1000;
       
    }
}
