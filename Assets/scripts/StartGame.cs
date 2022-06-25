using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //сылки на сцены для кнопок
    public void Play()
    {
        //загрузка игрового поля  
        SceneManager.LoadScene("SampleScene");
    }
    public void MainMenu()
    {
        //загрузка главного меню
        SceneManager.LoadScene("New Scene");
    }
    public void ScoreTable()
    {
        //загрузка окна с последним счетом 
        SceneManager.LoadScene("Score");
    }
}
