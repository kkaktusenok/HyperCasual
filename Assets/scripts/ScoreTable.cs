using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTable : MonoBehaviour
{
    //изменяеый текст
    public Text textScore;
    public Text textTime;

    void Update()
    {
        //замена переменных значениями 
        textScore.text = saveScore.scoreSave;
        textTime.text = saveScore.TimeSave;
    }
}
