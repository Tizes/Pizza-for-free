using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float num;
    public float timeLeft;
    public bool gameOver = false;
    public bool timerOn;
    public Text text;

    void Start()
    {
        timerOn = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                timeLeft = 0;
                timerOn = false;
            }
        }
    }
    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        text.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
