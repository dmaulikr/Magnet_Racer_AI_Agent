using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class particlemanager : MonoBehaviour {

    private float cycleinterval = 0.01f;

    public List<chargedparticle> chargedparticles;
    public List<movingchargedparticle> movingchargedparticles;

    void Start()
    {
        chargedparticles = new List<chargedparticle>(FindObjectsOfType<chargedparticle> ());
        movingchargedparticles = new List<movingchargedparticle>(FindObjectsOfType<movingchargedparticle>());


        movingchargedparticles.Add(new movingchargedparticle());

        foreach ( movingchargedparticle mcp in movingchargedparticles)
        {
            Debug.Log("coroutine");
            StartCoroutine(Cycle(mcp));
        }
    }

    public IEnumerator Cycle(movingchargedparticle mcp)
    {
        while (true)
        {
            applyMagneticForce(mcp);
            yield return new WaitForSeconds(cycleinterval);
        }


    }

    private void applyMagneticForce(movingchargedparticle mcp)
    {
        Vector2 newForce = Vector2.zero;

        foreach (chargedparticle cp in chargedparticles)
        {
            if (mcp == cp)
                continue;

            float distance = Vector2.Distance(mcp.transform.position, cp.gameObject.transform.position);
            float force = 1000 * mcp.charge * cp.charge / Mathf.Pow(distance, 2);

            Vector2 direction = mcp.transform.position - cp.transform.position;
            

            newForce += force * direction * cycleinterval;

            if (float.IsNaN(newForce.x))
                newForce = Vector2.zero;


            mcp.rb.AddForce(newForce);

            
            Debug.Log("applyMagneticForce");
        }
    }
}
