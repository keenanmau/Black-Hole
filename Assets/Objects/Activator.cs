using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    void Start()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //print("activated");

        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

   
}
