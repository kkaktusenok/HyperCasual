using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text timerText;
    public GameObject newScore;

    public float TimeStart = 0;

    private void Start()
    {
        timerText.text = TimeStart.ToString("F2");

    }

    //таймер и счетчик 
    void Update()
    {
        TimeStart += Time.deltaTime;
        timerText.text = TimeStart.ToString("F2");
        saveScore.scoreSave = scoreText.text;
        saveScore.TimeSave = TimeStart.ToString("F2");
    }
}
