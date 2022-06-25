using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endGame : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovement movement;
    public GameObject levlWin;
    public Text textScore;
    public Text textTime;
    public GameObject activeScore;

    private void OnTriggerEnter(Collider other)
    {
        //полная остановка персонажа и вывод окна с текстом и кнопками 
        movement.enabled = false;
        levlWin.SetActive(true);
        rb.drag = 1000;
        rb.freezeRotation = true;
        textScore.text = saveScore.scoreSave;
        textTime.text = saveScore.TimeSave;
        activeScore.SetActive(false);
    }
    public void Restart() { 
        //перезапуск сцены используеться для кнопок 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
