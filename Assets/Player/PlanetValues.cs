using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetValues : MonoBehaviour
{

    public float mass;
    public float scale;
    public bool eaten = false;
    public float multiplier = 1;

    void Start()
    {
        scale = transform.localScale.x;
        transform.localScale = new Vector3(scale, scale, 1);

    }

    void Update()
    {
        if (transform.localScale.x < .1)
        {
            Destroy(this.gameObject);
        }
        if (eaten)
        {
            scale -= Time.deltaTime * multiplier;
            transform.localScale = new Vector3(scale, scale, 1);
                
        }
    }

    public void BeginReduction()
    {
        eaten = true;
    }

}
