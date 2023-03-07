using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial1 : MonoBehaviour
{
    [SerializeField]
    GameObject[] images1, images2, images3, images4, images5, images6;
    int counter/*, counter2*/;
    [SerializeField]
    GameObject button1, button2, button3, button4, button5, button6;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        //counter2 = 0;
        for (int i = 0; i<images1.Length;i++)
        {
            images1[i+1].SetActive(false);
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void button1Count()
    {
        counter++;
        //counter2++;
        if (counter < images1.Length)
        {
            images1[counter].SetActive(true);
        }
        else
        {           
            button1.SetActive(false);
            button2.SetActive(true);
            counter = 0;
        }
        Debug.Log(counter);              
    }

    public void button2Count()
    {
        counter++;
        //counter2++;
        if ((counter -1)< images2.Length)
        {
            images2[counter-1].SetActive(true);
        }
        else
        {
            button2.SetActive(false);
            button3.SetActive(true);
            counter = 0;
        }
        Debug.Log(counter);
    }
    public void button3Count()
    {
        counter++;
        //counter2++;
        if ((counter - 1) < images3.Length)
        {
            images3[counter - 1].SetActive(true);
        }
        else
        {
            button3.SetActive(false);
            button4.SetActive(true);
            counter = 0;
        }
        Debug.Log(counter);
    }
    public void button4Count()
    {
        counter++;
        //counter2++;
        if ((counter - 1) < images4.Length)
        {
            images4[counter - 1].SetActive(true);
        }
        else
        {
            button4.SetActive(false);
            button5.SetActive(true);
            counter = 0;
        }
        Debug.Log(counter);
    }
    public void button5Count()
    {
        counter++;
        //counter2++;
        if ((counter - 1) < images5.Length)
        {
            images5[counter - 1].SetActive(true);
        }
        else
        {
            button5.SetActive(false);
            button6.SetActive(true);
            counter = 0;
        }
        Debug.Log(counter);
    }
    public void button6Count()
    {
        counter++;
        //counter2++;
        if ((counter - 1) < images6.Length)
        {
            images6[counter - 1].SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("IntroScene");
            PlayerPrefs.SetInt("isFirstTime", 1);
        }
        Debug.Log(counter);
    }

    public void skipTutorial()
    {
        SceneManager.LoadScene("IntroScene");
        PlayerPrefs.SetInt("isFirstTime", 1);
    }
    
}
