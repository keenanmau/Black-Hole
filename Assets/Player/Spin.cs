using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

    private float rotationModifier;
    // Start is called before the first frame update
    void Start()
    {
        rotationModifier = Random.Range(-2f, 2f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.back  * rotationModifier);
    }
}
