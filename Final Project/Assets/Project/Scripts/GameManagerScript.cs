using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public Text coinsLeft;

    public int current_coins = 0;
    public int max_coins = 0;
    public int current_keys = 0;

    public Text TimerText;
    private float startTime;

    public GameObject Door;
    public GameObject Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        
        startTime = Time.time;
        Door.SetActive(false);
        max_coins = current_coins;
        UpdateUI();

    }

       // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        TimerText.text = "Time Spent: " + minutes + ":" + seconds;
        
    }
  

    public void UpdateUI()
    {
        if(current_coins >= 0)
        {
            coinsLeft.text = "Coins Left: " + current_coins.ToString("D2") + "/" + max_coins.ToString("D2");
        }
        if(current_coins <= 0)
        {
            Door.SetActive(true);
        }
        
    }

    public void UpdateUI2()
    {
        if (current_keys <= 0)
        {
            Obstacle.SetActive(false);
        }

    }

   
}
