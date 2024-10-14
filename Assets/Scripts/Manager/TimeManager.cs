using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager:MonoBehaviour
{
    public Text currentTime;
    private void DisplayTime()
    {
        currentTime.text = DateTime.Now.ToString("HH:mm:ss");
    }

    private void Awake()
    {
        currentTime.gameObject.SetActive(true);
    }

    private void FixedUpdate()
    {
        DisplayTime();
    }
}