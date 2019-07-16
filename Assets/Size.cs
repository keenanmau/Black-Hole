using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{

    public float scale = 1;
    
    void Update()
    {
        increaseScale(1);
    }  

    public void increaseScale(float value)
    {
        scale += value;
        transform.localScale += new Vector3(0.1F, 0, 0);

    }

    
}
