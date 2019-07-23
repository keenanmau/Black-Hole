using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BHSpin : MonoBehaviour
{

    public float rotationModifier = 2;
    // Start is called before the first frame update
    void Start()
    {
        //rotationModifier = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.back  * rotationModifier);
    }
}
