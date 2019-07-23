using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityWell : MonoBehaviour
{
    // Start is called before the first frame update

    public float gravity = 1;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.CompareTag("Enemy"))
        {
            if (!other.CompareTag("Wall")) { 
            Rigidbody2D rigidbody = other.GetComponent<Rigidbody2D>();
            rigidbody.AddForce(getDirection(other.transform) * gravity);
        }
        }
        
    }

    private Vector2 getDirection(Transform t) {
        Vector2 a=  new Vector2(transform.position.x - t.position.x, transform.position.y - t.position.y);
        a.Normalize();
        return a;
    } 

    

    
}
