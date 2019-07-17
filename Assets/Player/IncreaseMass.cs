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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Object")
        {

            bhSize.increaseScale(other.gameObject.GetComponent<PlanetValues>().mass);

        }
    }
}
