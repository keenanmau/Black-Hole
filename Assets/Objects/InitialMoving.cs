using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialMoving : MonoBehaviour
{
    public float x, y;
     
    void Start()
    {

        Rigidbody2D[] RB = gameObject.GetComponentsInChildren<Rigidbody2D>();
        foreach (Rigidbody2D child in RB)
        {
            child.velocity = new Vector2(x, y);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
