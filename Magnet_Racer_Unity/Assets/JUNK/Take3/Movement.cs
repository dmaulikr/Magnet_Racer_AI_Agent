using UnityEngine;
using System.Collections;

public class Movement : MagScript {
    public float Speed = 10;
    Vector3 position;
    private Rigidbody2D rb;


    void Start()
    {
        position = transform.position;
        rb = GetComponent<Rigidbody2D>();

        updatecolor();
    }

    public void updatecolor()
    {
        //Debug.Log("works");
        Color color = charge1 > 0 ? Color.green : Color.red;
        GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            if (charge1 == 1)
                charge1 = -1;
            else if (charge1 == -1)
                charge1 = 1;
        }

        updatecolor();


        position.x += Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        position.z = 0;

        transform.position = position;

        if (Input.GetKeyDown(KeyCode.RightControl))
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
            Speed = 20;
        }
    }
}
