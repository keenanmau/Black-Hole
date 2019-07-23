using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{

    private float scale;
    public float pointsMass;
    public float mass;
    
    void Start()
    {
        scale = mass / 15000f;
        transform.localScale = new Vector3(scale, scale, 1);
    }


    
    public void increaseScale(float vMass)
    {
        pointsMass += vMass;
        scale = (mass  + pointsMass) / 15000;
        transform.localScale = new Vector3(scale, scale, 1);
    }

}
