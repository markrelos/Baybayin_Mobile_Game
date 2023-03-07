using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkTinapa : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3;
    [SerializeField]
    Image Ans1, Ans2, Ans3, Ans4, Ans5, Ans6, Ans7, Ans8, Ans9;
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
        int answer23 = PlayerPrefs.GetInt("Answer23", 0);
        int answer24 = PlayerPrefs.GetInt("Answer24", 0);
        int answer25 = PlayerPrefs.GetInt("Answer25", 0);
        int answer26 = PlayerPrefs.GetInt("Answer26", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 5)
        {
            nextButton.SetActive(true);
        }

        if (answer23 != 1)
        {
            Ans1.canvasRenderer.SetAlpha(0.0f);
            Ans2.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer24 != 1)
        {
            Ans3.canvasRenderer.SetAlpha(0.0f);
            Ans4.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer25 != 1)
        {
            Ans5.canvasRenderer.SetAlpha(0.0f);
            Ans6.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer26 != 1)
        {
            Ans7.canvasRenderer.SetAlpha(0.0f);
            Ans8.canvasRenderer.SetAlpha(0.0f);
            Ans9.canvasRenderer.SetAlpha(0.0f);
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
                PlayerPrefs.SetInt("Answer23", 1);
                if (PlayerPrefs.GetInt("Answer23Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer23Correct", 1);
                    PlayerPrefs.SetInt("Round5Complete", PlayerPrefs.GetInt("Round5Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile1)
            {
                Ans3.CrossFadeAlpha(1, 2, false);
                Ans4.CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer24", 1);
                if (PlayerPrefs.GetInt("Answer24Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer24Correct", 1);
                    PlayerPrefs.SetInt("Round5Complete", PlayerPrefs.GetInt("Round5Complete") + 1);
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
                Ans5.CrossFadeAlpha(1, 2, false);
                Ans6.CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer25", 1);
                if (PlayerPrefs.GetInt("Answer25Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer25Correct", 1);
                    PlayerPrefs.SetInt("Round5Complete", PlayerPrefs.GetInt("Round5Complete") + 1);
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
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3)
            {
                Ans7.CrossFadeAlpha(1, 2, false);
                Ans8.CrossFadeAlpha(1, 2, false);
                Ans9.CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer26", 1);
                if (PlayerPrefs.GetInt("Answer26Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer26Correct", 1);
                    PlayerPrefs.SetInt("Round5Complete", PlayerPrefs.GetInt("Round5Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 6)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 6);
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
        if (PlayerPrefs.GetInt("Round5Complete") == 4)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round5Complete", 5);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round5Complete") == 5)
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
        if (PlayerPrefs.GetInt("Answer23Correct") == 1)
        {
            Ans1.CrossFadeAlpha(1, 2, false);
            Ans2.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer24Correct") == 1)
        {
            Ans3.CrossFadeAlpha(1, 2, false);
            Ans4.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer25Correct") == 1)
        {
            Ans5.CrossFadeAlpha(1, 2, false);
            Ans6.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer26Correct") == 1)
        {
            Ans7.CrossFadeAlpha(1, 2, false);
            Ans8.CrossFadeAlpha(1, 2, false);
            Ans9.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 6)
        {
            if (PlayerPrefs.GetInt("levelFiveUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelFiveUnlocked", 1);
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

    public void HintLevelFive()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer23Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer23", 1);
                PlayerPrefs.SetInt("Answer23Correct", 1);
                PlayerPrefs.SetInt("Round5Complete", PlayerPrefs.GetInt("Round5Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer24Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer24", 1);
                    PlayerPrefs.SetInt("Answer24Correct", 1);
                    PlayerPrefs.SetInt("Round5Complete", PlayerPrefs.GetInt("Round5Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer25Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer25", 1);
                        PlayerPrefs.SetInt("Answer25Correct", 1);
                        PlayerPrefs.SetInt("Round5Complete", PlayerPrefs.GetInt("Round5Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        //PlayerPrefs.SetInt("levelUnlocked", 2);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer26Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer26", 1);
                            PlayerPrefs.SetInt("Answer26Correct", 1);
                            PlayerPrefs.SetInt("Round5Complete", PlayerPrefs.GetInt("Round5Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            if (PlayerPrefs.GetInt("levelUnlocked", 0) < 6)
                            {
                                PlayerPrefs.SetInt("levelUnlocked", 6);
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
