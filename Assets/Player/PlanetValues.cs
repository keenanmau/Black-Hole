using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetValues : MonoBehaviour
{

    //public float mass;
    public float pointMass;
    private float scale;
    public bool eaten;
    public float multiplier = 1;
    private GameObject bh;
    Rigidbody2D rb;

    void Start()
    {
        eaten = false;
        scale = transform.localScale.x;
        transform.localScale = new Vector3(scale, scale, 1);
        rb=GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (transform.localScale.x < .1)
        {
            Destroy(this.gameObject);
        }
        if (eaten)
        {   
            scale -= Time.deltaTime * multiplier ;
            transform.localScale = new Vector3(scale, scale, 1);
            GoToBlackHole();
        }
    }

    public void BeginReduction()
    {
        eaten = true; 
    } 

    public void setBH(GameObject blackHole)
    { 
        bh = blackHole.transform.root.gameObject;
    }

    private void GoToBlackHole()
    {
        Vector2 blackHolePosition = bh.transform.position;
        Vector2 currentPosition = transform.position;
        Vector2 veloc = blackHolePosition - currentPosition ;
        rb.velocity = veloc * 3.5f;
         //rb.mass = 0;
       

    }

}