using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMass : MonoBehaviour
{
    Size bhSize;
    void Start()
    {
        bhSize = GetComponentInParent<Size>();

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Object")
        {
            PlanetValues p = other.gameObject.GetComponent<PlanetValues>();
            if (!p.eaten)
            {
                p.BeginReduction();
                bhSize.increaseScale(p.pointMass);
            }
            p.setBH(transform.root.gameObject);
            

        }else if(other.gameObject.tag == "EnemyEventHorizon")
        {
            print("You Lose!");
            GameManager a = FindObjectOfType<GameManager>();
            a.YouLose();
        }

 
    }
}

