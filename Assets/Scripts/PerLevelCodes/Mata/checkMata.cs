using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class checkMata : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2;
    [SerializeField]
    Image[] Ans;        
    [SerializeField]
    Animator coinsOneAnimation, coinsFiveAnimation, congratsAnimation, hintAnimation, newLvlAnim, successAnim, perfectAnim, otherAnim;
    [SerializeField]
    GameObject coinsPanelOne, coinsPanelFive, congratsPanel, ansPanel, nextButton, tilePanel, hintPanel, newLvlPanel, successPanel, perfectPanel, otherPanel;
    [SerializeField]
    AudioSource correctSound, wrongSound;
    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 0; i < Ans.Length; i++)
        {
                Ans[i].canvasRenderer.SetAlpha(0.0f);
        }*/
        nextButton.SetActive(false);
        coinsPanelOne.SetActive(false);
        coinsPanelFive.SetActive(false);
        hintPanel.SetActive(false);
        newLvlPanel.SetActive(false);
        successPanel.SetActive(false);
        perfectPanel.SetActive(false);
        otherPanel.SetActive(false);
        int answer1 = PlayerPrefs.GetInt("Answer1", 0);
        int answer2 = PlayerPrefs.GetInt("Answer2", 0);
        int answer3 = PlayerPrefs.GetInt("Answer3", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");       


        if (unlockLevel > 1)
        {
            nextButton.SetActive(true);
        }
        if (answer1 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer2 != 1)
        {
            Ans[1].canvasRenderer.SetAlpha(0.0f);
            Ans[2].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer3 != 1)
        {
            Ans[3].canvasRenderer.SetAlpha(0.0f);
            Ans[4].canvasRenderer.SetAlpha(0.0f);
        }

    }

    public void checkAnswers()
    {
        if (parent.childCount == 1)
        {
            if (parent.transform.GetChild(0) == Tile1)
            {
                Ans[0].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer1", 1);
                if (PlayerPrefs.GetInt("Answer1Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer1Correct", 1);
                    PlayerPrefs.SetInt("Round1Complete", PlayerPrefs.GetInt("Round1Complete") + 1);                    
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
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 2)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2)
            {
                Ans[1].CrossFadeAlpha(1, 2, false);
                Ans[2].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                //nextImage.CrossFadeAlpha(1, 1, false);
                PlayerPrefs.SetInt("Answer2", 1);
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 2)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 2);
                }
                if (PlayerPrefs.GetInt("Answer2Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer2Correct", 1);
                    PlayerPrefs.SetInt("Round1Complete", PlayerPrefs.GetInt("Round1Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                    //StartCoroutine(newLvlAnimation());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1)
            {
                Ans[3].CrossFadeAlpha(1, 2, false);
                Ans[4].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                //nextImage.CrossFadeAlpha(1, 1, false);
                PlayerPrefs.SetInt("Answer3", 1);
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 2)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 2);
                }
                if (PlayerPrefs.GetInt("Answer3Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer3Correct", 1);
                    PlayerPrefs.SetInt("Round1Complete", PlayerPrefs.GetInt("Round1Complete") + 1);
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
                wrongSound.Play();
                Debug.Log("Return");
            }

        }

        else
        {
            Tile1.transform.SetParent(parentToReturnTo);
            Tile2.transform.SetParent(parentToReturnTo);
            wrongSound.Play();
            Debug.Log("Return");
        }
    }

    private void Update()
    {
        if(PlayerPrefs.GetInt("Round1Complete") == 3)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round1Complete", 4);
            StartCoroutine(coinsFivePanel());
        }
         if (PlayerPrefs.GetInt("Round1Complete") == 4)
        {          
            congratsPanel.SetActive(true);
            congratsAnimation.SetTrigger("Start");
            perfectPanel.SetActive(true);
            perfectAnim.SetTrigger("Start");
            otherPanel.SetActive(true);
            otherAnim.SetTrigger("Start");
            Debug.Log("play congrats sound");
            ansPanel.SetActive(false);
            nextButton.SetActive(false);
            tilePanel.SetActive(false);           
            Debug.Log("completed");
        }

        if (PlayerPrefs.GetInt("Answer1Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer2Correct") == 1)
        {
            Ans[1].CrossFadeAlpha(1, 2, false);
            Ans[2].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer3Correct") == 1)
        {
            Ans[3].CrossFadeAlpha(1, 2, false);
            Ans[4].CrossFadeAlpha(1, 2, false);          
        }

        if(PlayerPrefs.GetInt("levelUnlocked") == 2)
        {
            if (PlayerPrefs.GetInt("levelOneUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelOneUnlocked", 1);
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

    public void HintLevelOne()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {           
            if (PlayerPrefs.GetInt("Answer1Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer1", 1);
                PlayerPrefs.SetInt("Answer1Correct", 1);
                PlayerPrefs.SetInt("Round1Complete", PlayerPrefs.GetInt("Round1Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if(PlayerPrefs.GetInt("Answer2Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer2", 1);
                    PlayerPrefs.SetInt("Answer2Correct", 1);
                    PlayerPrefs.SetInt("Round1Complete", PlayerPrefs.GetInt("Round1Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    if (PlayerPrefs.GetInt("levelUnlocked", 0) < 2)
                    {
                        PlayerPrefs.SetInt("levelUnlocked", 2);
                    }
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if(PlayerPrefs.GetInt("Answer3Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer3", 1);
                        PlayerPrefs.SetInt("Answer3Correct", 1);
                        PlayerPrefs.SetInt("Round1Complete", PlayerPrefs.GetInt("Round1Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        if (PlayerPrefs.GetInt("levelUnlocked", 0) < 2)
                        {
                            PlayerPrefs.SetInt("levelUnlocked", 2);
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
