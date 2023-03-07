using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class checkGreetings1 : MonoBehaviour
{
    [SerializeField]
    GameObject congratsPanel, otherPanel, enterButton, backButton, inputObj, ansHolder;
    [SerializeField]
    Animator congratsAnim, otherAnim;
    public TMP_InputField inputName;
    string answerText;
    [SerializeField]
    string answer;
    [SerializeField]
    AudioSource correctSound, wrongSound;
    // Start is called before the first frame update
    void Start()
    {
        congratsPanel.SetActive(false);
        otherPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkAnswer()
    {
        answerText = inputName.text;
        if (answerText.Equals(answer, StringComparison.InvariantCultureIgnoreCase))
        {
            congratsPanel.SetActive(true);
            congratsAnim.SetTrigger("Start");
            otherPanel.SetActive(true);
            otherAnim.SetTrigger("Start");
            enterButton.SetActive(false);
            backButton.SetActive(false);
            inputObj.SetActive(false);
            correctSound.Play();
            
        }

        else
        {
            wrongSound.Play();
            Debug.Log(inputName.text);
            Debug.Log(answer);
            Debug.Log(string.Equals(answerText, answer));
        }
      
    }
}
