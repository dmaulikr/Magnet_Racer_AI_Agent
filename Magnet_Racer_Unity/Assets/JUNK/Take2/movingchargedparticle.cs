using UnityEngine;
using System.Collections;

public class movingchargedparticle : chargedparticle {
    public float mass = 1;
    public Rigidbody2D rb;

    //public movingchargedparticle(float mass , Rigidbody2D rb)
    void Start()
    {
       // Debug.Log("you there");
        updatecolor();

        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.mass = mass;

        rb.gravityScale = 0;

    }


}
