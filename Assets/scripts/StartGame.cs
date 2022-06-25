using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //����� �� ����� ��� ������
    public void Play()
    {
        //�������� �������� ����  
        SceneManager.LoadScene("SampleScene");
    }
    public void MainMenu()
    {
        //�������� �������� ����
        SceneManager.LoadScene("New Scene");
    }
    public void ScoreTable()
    {
        //�������� ���� � ��������� ������ 
        SceneManager.LoadScene("Score");
    }
}
