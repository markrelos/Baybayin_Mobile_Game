using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class WordGuessTutScript : MonoBehaviour
{
    [SerializeField]
    TMP_InputField input1;
    [SerializeField]
    GameObject menuButton, answerPanel, whatImage, congratsPanel;
    [SerializeField]
    GameObject[] tutImages;
    int counter;
    [SerializeField]
    Button nextButton, enterButt, homeButton;
    string answer, answerText;
    [SerializeField]
    AudioSource correctSound;
    // Start is called before the first frame update
    void Start()
    {
        answer = "Paalam";
        counter = 0;
        input1.interactable = false;
        menuButton.SetActive(false);
        answerPanel.SetActive(false);
        whatImage.SetActive(false);
        congratsPanel.SetActive(false);
        nextButton.interactable = false;
        enterButt.interactable = false;
        homeButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(counter);
        if(counter == 1)
        {
            answerPanel.SetActive(true);
            whatImage.SetActive(true);
            tutImages[0].SetActive(false);
            tutImages[1].SetActive(true);
            tutImages[2].SetActive(true);
        }
        else if (counter == 2)
        {
            input1.interactable = true;
            tutImages[1].SetActive(false);
            tutImages[2].SetActive(false);
            tutImages[3].SetActive(true);
            tutImages[4].SetActive(true);
        }
        else if (counter == 3)
        {
            enterButt.interactable = true;
            tutImages[3].SetActive(false);
            tutImages[4].SetActive(false);
            tutImages[5].SetActive(true);
            tutImages[6].SetActive(true);
        }
        else if (counter == 500)
        {
            tutImages[9].SetActive(true);
            enterButt.interactable = false;
        }
        else if (counter == 501)
        {
            tutImages[9].SetActive(false);
            tutImages[10].SetActive(true);
            tutImages[11].SetActive(true);

        }
        else if (counter == 502)
        {
            tutImages[10].SetActive(false);
            tutImages[11].SetActive(false);
            tutImages[12].SetActive(true);
            tutImages[13].SetActive(true);

        }
        else if (counter == 503)
        {
            PlayerPrefs.SetInt("isFirstTimeWordGuess", 1);
            SceneManager.LoadScene("WordGuess");

        }
    }

    public void buttonCounter()
    {
        counter++;
    }

    public void enterButton()
    {
        answerText = input1.text;
        if (answerText.Equals(answer, StringComparison.InvariantCultureIgnoreCase))
        {
            congratsPanel.SetActive(true);
            correctSound.Play();
            tutImages[5].SetActive(false);
            tutImages[6].SetActive(false);
            tutImages[7].SetActive(false);
            tutImages[8].SetActive(false);
            counter = 500;
        }
        else
        {
            counter++;
            tutImages[5].SetActive(false);
            tutImages[6].SetActive(false);
            tutImages[7].SetActive(true);
            tutImages[8].SetActive(true);
        }
    }

    public void skipTutWordGuess()
    {
        PlayerPrefs.SetInt("isFirstTimeWordGuess", 1);
        SceneManager.LoadScene("WordGuess");
    }
}
