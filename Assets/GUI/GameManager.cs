using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    TextManager txtManage;
    LevelManager lvlManage;
    public float timer = 240;
    public GameObject player;
    GameObject Panel;
    private bool lost = false;
    public bool level5;
    void Start()
    {
        txtManage = gameObject.GetComponent<TextManager>();
        lvlManage = gameObject.GetComponent<LevelManager>();
        player = GameObject.Find("Black_Hole");
        if(player == null)
        {
            print("Error: Player Black Hole not found");
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float pointmass = player.GetComponent<Size>().pointsMass;
        txtManage.UpdateTimer(timer.ToString("F1"));
        txtManage.UpdateMass(pointmass.ToString("F2"));
        timer -= Time.deltaTime;

        if(pointmass >= 10000 && !level5)
        {
            GoToNextLevel();
        }
        if(timer <= 0)
        {
            lost = true;
        }
        if (lost)
        {
            LoadLoseLevel();
        }
        if(level5 && pointmass >= 100000)
        {
            lvlManage.LoadLevel("Win_Level");
        }

    }

    void GoToNextLevel()
    {
        lvlManage.LoadNextLevel();
    }


    public void YouLose()
    {
        print("Game Manager says you lose!");
        Movement p = player.transform.root.GetComponent<Movement>();
        p.enabled = false;

        Invoke("LoadLoseLevel", 1f);
    }

    private void LoadLoseLevel()
    {
        lvlManage.LoadLevel("Lose_Level");
    }

}
