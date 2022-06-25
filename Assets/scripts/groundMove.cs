using UnityEngine;
using UnityEngine.UI;

public class groundMove : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;
    public GameObject obt1;
    public GameObject obt2;
    public GameObject obt3;
    public GameObject obt4;
    public GameObject obt5;
    public GameObject obt6;
    public GameObject obt7;
    public GameObject obt8;
    public GameObject godMode;
    public Text time;
    public Text Score;
    int forwardForce = 10;
    private void FixedUpdate()
    {
        Vector3 input = new Vector3(0, 0, -1);
        transform.position = transform.position + input * Time.deltaTime * forwardForce;

        if (forwardForce == 25|| forwardForce == 40 || forwardForce == 45||forwardForce == 60)
        {
            PlayerMovement.stepan = false;
            godMode.SetActive(true);
        }

        else
        {
            PlayerMovement.stepan = true;
            godMode.SetActive(false);
        }
    }
    public static string scores = "0";
    private void Update()
    {
        if (time.text == "20,00")
        {
            forwardForce = 15;
            scores = "100";
            Score.text = scores;

        }
        else if (time.text == "40,00")
        {
            forwardForce = 20;
            scores = "200";
            Score.text = scores;
        }
        else if (time.text == "60,00")
        {
            forwardForce = 25;
            scores = "300";
            Score.text = scores;
        }
        else if (time.text == "80,00")
        {
            forwardForce = 30;
            scores = "400";
            Score.text = scores;
        }
        else if (time.text == "100,00")
        {
            forwardForce = 35;
            scores = "500";
            Score.text = scores;
        }
        else if (time.text == "120,00")
        {
            forwardForce = 40;
            scores = "600";
            Score.text = scores;
        }
        else if (time.text == "140,00")
        {
            forwardForce = 45;
            scores = "700";
            Score.text = scores;
        }
        else if (time.text == "160,00")
        {
            forwardForce = 50;
            scores = "800";
            Score.text = scores;
        }
        else if (time.text == "180,00")
        {
            forwardForce = 55;
            scores = "900";
            Score.text = scores;
        }
        else if (time.text == "200,00")
        {
            forwardForce = 60;
            scores = "1000";
            Score.text = scores;
        }

        if (platform1.transform.position.z < 316.2)
        {
            //randoms
            int random = Random.Range(1, 4);
            int random1 = Random.Range(1, 4);

            platform1.transform.position = new Vector3(0, 0, 716);

            if (random == 1)
            {
                obt1.transform.position = new Vector3(-15, 2, 750);
            }
            if (random == 2)
            {
                obt1.transform.position = new Vector3(15, 2, 750);
            }
            else if (random == 3)
            {
                obt1.transform.position = new Vector3(0, 2, 750);
            }
 
            //obt2

            if (random1 == 1)
            {
                obt2.transform.position = new Vector3(-15, 2, 700);
            }
            if (random1 == 2)
            {
                obt2.transform.position = new Vector3(15, 2, 700);
            }
            else if(random1 == 3)
            {
                obt2.transform.position = new Vector3(0, 2, 700);
            }
            obt1.SetActive(true);
            obt2.SetActive(true);

        }

        if (platform2.transform.position.z < 316.2)
        {
            platform2.transform.position = new Vector3(0, 0, 716);

            //randoms
            int random3 = Random.Range(1, 4);
            int random4 = Random.Range(1, 4);

            //obt3
            if (random3 == 1)
            {
                obt3.transform.position = new Vector3(-15, 2, 750);
            }
            if (random3 == 2)
            {
                obt3.transform.position = new Vector3(15, 2, 750);
            }
            else if(random3 == 3)
            {
                obt3.transform.position = new Vector3(0, 2, 750);
            }
            //obt4

            if (random4 == 1)
            {
                obt4.transform.position = new Vector3(-15, 2, 700);
            }
            if (random4 == 2)
            {
                obt4.transform.position = new Vector3(15, 2, 700);
            }
            else if(random4 == 3)
            {
                obt4.transform.position = new Vector3(0, 2, 700);
            }
            obt3.SetActive(true);
            obt4.SetActive(true);

        }

        if (platform3.transform.position.z < 316.2)
        {
            platform3.transform.position = new Vector3(0, 0, 716);

            //randoms
            int random5 = Random.Range(1, 4);
            int random6 = Random.Range(1, 4);

            //obt5
            if (random5 == 1)
            {
                obt5.transform.position = new Vector3(-15, 2, 750);
            }
            if (random5 == 2)
            {
                obt5.transform.position = new Vector3(15, 2, 750);
            }
            else if(random5 == 3)
            {
                obt5.transform.position = new Vector3(0, 2, 750);
            }
            //obt6

            if (random6 == 1)
            {
                obt6.transform.position = new Vector3(-15, 2, 700);
            }
            if (random6 == 2)
            {
                obt6.transform.position = new Vector3(15, 2, 700);
            }
            else if(random6 == 3)
            {
                obt6.transform.position = new Vector3(0, 2, 700);
            }
            obt5.SetActive(true);
            obt6.SetActive(true);
        }

        if (platform4.transform.position.z < 316.2)
        {
            platform4.transform.position = new Vector3(0, 0, 716);

            //randoms
            int random7 = Random.Range(1, 4);
            int random8 = Random.Range(1, 4);

            //obt7
            if (random7 == 1)
            {
                obt7.transform.position = new Vector3(-15, 2, 750);
            }
            if (random7 == 2)
            {
                obt7.transform.position = new Vector3(15, 2, 750);
            }
            else if(random7 == 3)
            {
                obt7.transform.position = new Vector3(0, 2, 750);
            }
            //obt8

            if (random8 == 1)
            {
                obt8.transform.position = new Vector3(-15, 2, 700);
            }
            if (random8 == 2)
            {
                obt8.transform.position = new Vector3(15, 2, 700);
            }
            else if(random8 == 3)
            {
                obt8.transform.position = new Vector3(0, 2, 700);
            }
            obt7.SetActive(true);
            obt8.SetActive(true);
        }
    }
}
