using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb;
    public float multiplier;
    void Start()
    {
        if(player == null)
        {
            Debug.LogError("Player Object not found");

        }
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = transform.position + new Vector3(rb.velocity.x * multiplier, rb.velocity.y * multiplier);
        transform.position = newpos;
        
    }
}
