using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTable : MonoBehaviour
{
    //��������� �����
    public Text textScore;
    public Text textTime;

    void Update()
    {
        //������ ���������� ���������� 
        textScore.text = saveScore.scoreSave;
        textTime.text = saveScore.TimeSave;
    }
}
