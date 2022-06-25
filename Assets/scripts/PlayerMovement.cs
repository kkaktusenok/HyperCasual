using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovement movement;
    public GameObject loseGame;
    public float forwardForce = 50f;
    public float sidewaysForce = 500f;
    public Text textScore;
    public Text textTime;
    public GameObject activeScore;
    public GameObject coin1;
    public int CoinScoreT = 0;
    public static bool stepan = true;
    void FixedUpdate()
    {

        //������������ ��������� �� ������� WASD
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("New Scene");
        }



        //������������ ���� ������� ��������� ������ -2f �� y
        if (rb.position.y < -2f)
        {
            //������� ��������� ��������� � ����� �� ����� ���� � ������� � �������� 
            movement.enabled = false;
            loseGame.SetActive(true);
            rb.drag = 1000;
            rb.freezeRotation = true;
            textScore.text = saveScore.scoreSave;
            textTime.text = saveScore.TimeSave;
            activeScore.SetActive(false);
        }
    }
    //������������ ���� �������� ��������� ������� � ����� Obtakle
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obtakle" && stepan == true)
        {
            //������� ��������� ��������� � ����� �� ����� ���� � ������� � �������� 
            movement.enabled = false;
            loseGame.SetActive(true);
            rb.drag = 1000;
            rb.freezeRotation = true;
            textScore.text = saveScore.scoreSave;
            textTime.text = saveScore.TimeSave;
            activeScore.SetActive(false);
            saveScore.scoreSave = groundMove.scores;
            collisionInfo.gameObject.SetActive(true);

        }
        else if(collisionInfo.collider.tag == "Obtakle" && stepan == false)
        {
            collisionInfo.gameObject.SetActive(false);
        }
    }
}
