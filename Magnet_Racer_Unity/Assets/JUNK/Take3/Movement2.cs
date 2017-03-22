using UnityEngine;
using System.Collections;

public class Movement2 : MagScript {


    public float Speed2 = 10;
    Vector3 position2;
    private Rigidbody2D rb;

    void Start()
    {
        position2 = transform.position;
        rb = GetComponent<Rigidbody2D>();

        updatecolor();
    }

    // Update is called once per frame
    public void updatecolor()
    {
        //Debug.Log("works");
        Color color = charge1 > 0 ? Color.green : Color.red;
        GetComponent<Renderer>().material.color = color;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (charge1 == 1)
                charge1 = -1;
            else if (charge1 == -1)
                charge1 = 1;
        }

        updatecolor();

        position2.x += Input.GetAxis("Horizontal2") * Speed2 * Time.deltaTime;
        position2.y += Input.GetAxis("Vertical2") * Speed2 * Time.deltaTime;
        position2.z = 0;

        transform.position = position2;


        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, 0, 90);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("yogo");

        if (other.gameObject.CompareTag("speed"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
