using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class racer2 : MonoBehaviour
{

    public float Speed = 1000;
    Vector2 position2;
    private Rigidbody2D rb;
    private bool flag =false;

    void Start()
    {
        position2 = transform.position;
        rb = GetComponent<Rigidbody2D>();


    }

    void OnGUI()
    {   if(flag == true)
        GUI.Label(new Rect(10, 10, 100, 20), "WINNER!");
    }

    void Update()
    {
        /*
 position2.x += Input.GetAxis("Horizontal2") * Speed * Time.deltaTime;
 position2.y += Input.GetAxis("Vertical2") * Speed * Time.deltaTime;

 transform.position = position2;
 */

        if (Input.GetKeyDown(KeyCode.S))
            rb.AddForce(-Vector2.up * Speed);
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.zero);
        }

        if (Input.GetKeyDown(KeyCode.W))
            rb.AddForce(Vector2.up * Speed);
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.zero);
        }


        if (Input.GetKeyDown(KeyCode.A))
            rb.AddForce(-Vector2.right * Speed);
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.zero);
        }

        if (Input.GetKeyDown(KeyCode.D))
            rb.AddForce(Vector2.right * Speed);
        if (Input.GetKeyUp(KeyCode.D))
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


    }
}
