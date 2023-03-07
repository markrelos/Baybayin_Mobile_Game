using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckTalaba : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3;
    [SerializeField]
    Image Ans1, Ans2, Ans3, Ans4, Ans5, Ans6, Ans7, Ans8, Ans9, Ans10, Ans11, Ans12, Ans13, Ans14, Ans15;
    [SerializeField]
    Animator coinsOneAnimation, coinsFiveAnimation, congratsAnimation, hintAnimation, successAnim, newLvlAnim, perfectAnim, otherAnim;
    [SerializeField]
    GameObject coinsPanelOne, coinsPanelFive, congratsPanel, ansPanel, nextButton, tilePanel, hintPanel, successPanel, newLvlPanel, perfectPanel, otherPanel;
    [SerializeField]
    AudioSource correctSound, wrongSound;
    // Start is called before the first frame update
    void Start()
    {
        nextButton.SetActive(false);
        coinsPanelOne.SetActive(false);
        coinsPanelFive.SetActive(false);
        hintPanel.SetActive(false);
        successPanel.SetActive(false);
        newLvlPanel.SetActive(false);
        perfectPanel.SetActive(false);
        otherPanel.SetActive(false);
        int answer4 = PlayerPrefs.GetInt("Answer4", 0);
        int answer5 = PlayerPrefs.GetInt("Answer5", 0);
        int answer6 = PlayerPrefs.GetInt("Answer6", 0);
        int answer7 = PlayerPrefs.GetInt("Answer7", 0);
        int answer8 = PlayerPrefs.GetInt("Answer8", 0);
        int answer9 = PlayerPrefs.GetInt("Answer9", 0);
        int answer10 = PlayerPrefs.GetInt("Answer10", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 2)
        {
            nextButton.SetActive(true);
        }

        if (answer4 != 1)
        {
            Ans1.canvasRenderer.SetAlpha(0.0f);
            Ans2.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer5 != 1)
        {
            Ans3.canvasRenderer.SetAlpha(0.0f);
            Ans4.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer6 != 1)
        {
            Ans5.canvasRenderer.SetAlpha(0.0f);
            Ans6.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer7 != 1)
        {
            Ans7.canvasRenderer.SetAlpha(0.0f);
            Ans8.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer8 != 1)
        {
            Ans9.canvasRenderer.SetAlpha(0.0f);
            Ans10.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer9 != 1)
        {
            Ans11.canvasRenderer.SetAlpha(0.0f);
            Ans12.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer10 != 1)
        {
            Ans13.canvasRenderer.SetAlpha(0.0f);
            Ans14.canvasRenderer.SetAlpha(0.0f);
            Ans15.canvasRenderer.SetAlpha(0.0f);
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
                PlayerPrefs.SetInt("Answer4", 1);
                if (PlayerPrefs.GetInt("Answer4Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer4Correct", 1);
                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
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
                PlayerPrefs.SetInt("Answer5", 1);
                if (PlayerPrefs.GetInt("Answer5Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer5Correct", 1);
                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
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
                PlayerPrefs.SetInt("Answer6", 1);
                if (PlayerPrefs.GetInt("Answer6Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer6Correct", 1);
                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
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
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer7", 1);
                if (PlayerPrefs.GetInt("Answer7Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer7Correct", 1);
                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
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
                Ans9.CrossFadeAlpha(1, 2, false);
                Ans10.CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer8", 1);
                if (PlayerPrefs.GetInt("Answer8Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer8Correct", 1);
                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
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
                Ans11.CrossFadeAlpha(1, 2, false);
                Ans12.CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer9", 1);
                if (PlayerPrefs.GetInt("Answer9Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer9Correct", 1);
                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
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
                Ans13.CrossFadeAlpha(1, 2, false);
                Ans14.CrossFadeAlpha(1, 2, false);
                Ans15.CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer10", 1);
                if (PlayerPrefs.GetInt("Answer10Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer10Correct", 1);
                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 3)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 3);
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
        if (PlayerPrefs.GetInt("Round2Complete") == 7)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round2Complete", 8);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round2Complete") == 8)
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

        if (PlayerPrefs.GetInt("Answer4Correct") == 1)
        {
            Ans1.CrossFadeAlpha(1, 2, false);
            Ans2.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer5Correct") == 1)
        {
            Ans3.CrossFadeAlpha(1, 2, false);
            Ans4.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer6Correct") == 1)
        {
            Ans5.CrossFadeAlpha(1, 2, false);
            Ans6.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer7Correct") == 1)
        {
            Ans7.CrossFadeAlpha(1, 2, false);
            Ans8.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer8Correct") == 1)
        {
            Ans9.CrossFadeAlpha(1, 2, false);
            Ans10.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer9Correct") == 1)
        {
            Ans11.CrossFadeAlpha(1, 2, false);
            Ans12.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer10Correct") == 1)
        {
            Ans13.CrossFadeAlpha(1, 2, false);
            Ans14.CrossFadeAlpha(1, 2, false);
            Ans15.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 3)
        {
            if (PlayerPrefs.GetInt("levelTwoUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelTwoUnlocked", 1);
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

    public void HintLevelTwo()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer4Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer4", 1);
                PlayerPrefs.SetInt("Answer4Correct", 1);
                PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer5Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer5", 1);
                    PlayerPrefs.SetInt("Answer5Correct", 1);
                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer6Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer6", 1);
                        PlayerPrefs.SetInt("Answer6Correct", 1);
                        PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        //PlayerPrefs.SetInt("levelUnlocked", 2);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer7Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer7", 1);
                            PlayerPrefs.SetInt("Answer7Correct", 1);
                            PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            //PlayerPrefs.SetInt("levelUnlocked", 2);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer8Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer8", 1);
                                PlayerPrefs.SetInt("Answer8Correct", 1);
                                PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                //PlayerPrefs.SetInt("levelUnlocked", 2);
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer9Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer9", 1);
                                    PlayerPrefs.SetInt("Answer9Correct", 1);
                                    PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    //PlayerPrefs.SetInt("levelUnlocked", 2);
                                    hintPanel.SetActive(false);
                                    correctSound.Play();
                                }
                                else
                                {
                                    if (PlayerPrefs.GetInt("Answer10Correct") == 0)
                                    {
                                        PlayerPrefs.SetInt("Answer10", 1);
                                        PlayerPrefs.SetInt("Answer10Correct", 1);
                                        PlayerPrefs.SetInt("Round2Complete", PlayerPrefs.GetInt("Round2Complete") + 1);
                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                        if (PlayerPrefs.GetInt("levelUnlocked", 0) < 3)
                                        {
                                            PlayerPrefs.SetInt("levelUnlocked", 3);
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
