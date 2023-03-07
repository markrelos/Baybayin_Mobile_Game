﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkKasama : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3;
    [SerializeField]
    Image Ans1, Ans2, Ans3, Ans4, Ans5, Ans6, Ans7, Ans8, Ans9, Ans10, Ans11, Ans12, Ans13;
    [SerializeField]
    Animator coinsOneAnimation, coinsFiveAnimation, congratsAnimation, hintAnimation, successAnim, newLvlAnim, perfectAnim, otherAnim;
    [SerializeField]
    GameObject coinsPanelOne, coinsPanelFive, congratsPanel, ansPanel, nextButton, tilePanel, hintPanel, successPanel, newLvlPanel, perfectPanel, otherPanel;
    [SerializeField]
    AudioSource correctSound, wrongSound;
    // Start is called before the first frame update
    void Start()
    {
        coinsPanelOne.SetActive(false);
        coinsPanelFive.SetActive(false);
        nextButton.SetActive(false);
        hintPanel.SetActive(false);
        successPanel.SetActive(false);
        newLvlPanel.SetActive(false);
        perfectPanel.SetActive(false);
        otherPanel.SetActive(false);
        int answer17 = PlayerPrefs.GetInt("Answer17", 0);
        int answer18 = PlayerPrefs.GetInt("Answer18", 0);
        int answer19 = PlayerPrefs.GetInt("Answer19", 0);
        int answer20 = PlayerPrefs.GetInt("Answer20", 0);
        int answer21 = PlayerPrefs.GetInt("Answer21", 0);
        int answer22 = PlayerPrefs.GetInt("Answer22", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 4)
        {
            nextButton.SetActive(true);
        }

        if (answer17 != 1)
        {
            Ans1.canvasRenderer.SetAlpha(0.0f);
            Ans2.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer18 != 1)
        {
            Ans3.canvasRenderer.SetAlpha(0.0f);
            Ans4.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer19 != 1)
        {
            Ans5.canvasRenderer.SetAlpha(0.0f);
            Ans6.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer20 != 1)
        {
            Ans7.canvasRenderer.SetAlpha(0.0f);
            Ans8.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer21 != 1)
        {
            Ans9.canvasRenderer.SetAlpha(0.0f);
            Ans10.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer22 != 1)
        {
            Ans11.canvasRenderer.SetAlpha(0.0f);
            Ans12.canvasRenderer.SetAlpha(0.0f);
            Ans13.canvasRenderer.SetAlpha(0.0f);
        }

    }

    public void checkAnswers()
    {
        if (parent.childCount == 2)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2)
            {
                Ans1.CrossFadeAlpha(1, 2, false);
                Ans2.CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer17", 1);
                if (PlayerPrefs.GetInt("Answer17Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer17Correct", 1);
                    PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3)
            {
                Ans3.CrossFadeAlpha(1, 2, false);
                Ans4.CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer18", 1);
                if (PlayerPrefs.GetInt("Answer18Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer18Correct", 1);
                    PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1)
            {
                Ans5.CrossFadeAlpha(1, 2, false);
                Ans6.CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer19", 1);
                if (PlayerPrefs.GetInt("Answer19Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer19Correct", 1);
                    PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile3)
            {
                Ans7.CrossFadeAlpha(1, 2, false);
                Ans8.CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer20", 1);
                if (PlayerPrefs.GetInt("Answer20Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer20Correct", 1);
                    PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile2)
            {
                Ans9.CrossFadeAlpha(1, 2, false);
                Ans10.CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer21", 1);
                if (PlayerPrefs.GetInt("Answer21Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer21Correct", 1);
                    PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 3)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2))
            {
                Ans11.CrossFadeAlpha(1, 2, false);
                Ans12.CrossFadeAlpha(1, 2, false);
                Ans13.CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer22", 1);
                if (PlayerPrefs.GetInt("Answer22Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer22Correct", 1);
                    PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 5)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 5);
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }

        }

        else
        {
            Tile1.transform.SetParent(parentToReturnTo);
            Tile2.transform.SetParent(parentToReturnTo);
            Tile3.transform.SetParent(parentToReturnTo);
            wrongSound.Play();
            Debug.Log("Return");
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Round4Complete") == 6)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round4Complete", 7);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round4Complete") == 7)
        {
            congratsPanel.SetActive(true);
            congratsAnimation.SetTrigger("Start");
            perfectPanel.SetActive(true);
            perfectAnim.SetTrigger("Start");
            otherPanel.SetActive(true);
            otherAnim.SetTrigger("Start");
            ansPanel.SetActive(false);
            nextButton.SetActive(false);
            tilePanel.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Answer17Correct") == 1)
        {
            Ans1.CrossFadeAlpha(1, 2, false);
            Ans2.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer18Correct") == 1)
        {
            Ans3.CrossFadeAlpha(1, 2, false);
            Ans4.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer19Correct") == 1)
        {
            Ans5.CrossFadeAlpha(1, 2, false);
            Ans6.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer20Correct") == 1)
        {
            Ans7.CrossFadeAlpha(1, 2, false);
            Ans8.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer21Correct") == 1)
        {
            Ans9.CrossFadeAlpha(1, 2, false);
            Ans10.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer22Correct") == 1)
        {
            Ans11.CrossFadeAlpha(1, 2, false);
            Ans12.CrossFadeAlpha(1, 2, false);
            Ans13.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 5)
        {
            if (PlayerPrefs.GetInt("levelFourUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelFourUnlocked", 1);
            }
        }
    }
    IEnumerator coinsPanel()
    {
        coinsPanelOne.SetActive(true);
        coinsOneAnimation.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        coinsPanelOne.SetActive(false);
    }
    IEnumerator coinsFivePanel()
    {
        coinsPanelFive.SetActive(true);
        coinsFiveAnimation.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        coinsPanelFive.SetActive(false);
    }
    IEnumerator hintPanelAnim()
    {
        yield return new WaitForSeconds(0f);
        hintPanel.SetActive(true);
        hintAnimation.SetTrigger("Start");
    }
    IEnumerator newLvlAnimation()
    {
        newLvlPanel.SetActive(true);
        newLvlAnim.SetTrigger("Start");
        yield return new WaitForSeconds(3f);
        newLvlPanel.SetActive(false);
    }
    public void HintLevelFour()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer17Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer17", 1);
                PlayerPrefs.SetInt("Answer17Correct", 1);
                PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer18Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer18", 1);
                    PlayerPrefs.SetInt("Answer18Correct", 1);
                    PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer19Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer19", 1);
                        PlayerPrefs.SetInt("Answer19Correct", 1);
                        PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        //PlayerPrefs.SetInt("levelUnlocked", 2);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer20Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer20", 1);
                            PlayerPrefs.SetInt("Answer20Correct", 1);
                            PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            //PlayerPrefs.SetInt("levelUnlocked", 2);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer21Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer21", 1);
                                PlayerPrefs.SetInt("Answer21Correct", 1);
                                PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                //PlayerPrefs.SetInt("levelUnlocked", 2);
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer22Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer22", 1);
                                    PlayerPrefs.SetInt("Answer22Correct", 1);
                                    PlayerPrefs.SetInt("Round4Complete", PlayerPrefs.GetInt("Round4Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    if (PlayerPrefs.GetInt("levelUnlocked", 0) < 5)
                                    {
                                        PlayerPrefs.SetInt("levelUnlocked", 5);
                                    }
                                    hintPanel.SetActive(false);
                                    correctSound.Play();
                                }
                                else
                                {
                                    wrongSound.Play();
                                }
                            }
                        }
                    }
                }
            }
        }
        else
        {
            wrongSound.Play();
        }
    }
    public void HintMain()
    {
        StartCoroutine(hintPanelAnim());
    }
    public void closeHint()
    {
        hintPanel.SetActive(false);
    }

    public void successPanelActivate()
    {
        successPanel.SetActive(true);
        successAnim.SetTrigger("Start");
        otherPanel.SetActive(true);
        otherAnim.SetTrigger("Start");
        ansPanel.SetActive(false);
        nextButton.SetActive(false);
        tilePanel.SetActive(false);
    }
}
