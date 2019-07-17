using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{

    public float scale = 1;
    public float mass = 100;
    public bool Test;
    
    void Start()
    {

    }

    void Update()
    {
        if (Test)
        {
            Test = !Test;
            increaseScale(100);
        }
    }
    
    public void increaseScale(float vMass)
    {
        mass += vMass;
        scale = mass / 100;
        transform.localScale = new Vector3(scale, scale, 1);

    }

}
