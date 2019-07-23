using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text massText;
    public Text timerText;
   // public GameObject blackhole;
    private Size s;
    void Start()
    {
    }

    public void UpdateMass(string m)
    {
        massText.text = "Mass: " + m;
        
    }

    public void UpdateTimer(string t)
    {
        timerText.text = "Time: " + t;
    }
}
