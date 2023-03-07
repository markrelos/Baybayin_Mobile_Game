using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkMasaya : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3;
    [SerializeField]
    Image Ans1, Ans2, Ans3, Ans4, Ans5, Ans6, Ans7, Ans8, Ans9, Ans10, Ans11;
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
        int answer27 = PlayerPrefs.GetInt("Answer27", 0);
        int answer28 = PlayerPrefs.GetInt("Answer28", 0);
        int answer29 = PlayerPrefs.GetInt("Answer29", 0);
        int answer30 = PlayerPrefs.GetInt("Answer30", 0);
        int answer31 = PlayerPrefs.GetInt("Answer31", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 6)
        {
            nextButton.SetActive(true);
        }

        if (answer27 != 1)
        {
            Ans1.canvasRenderer.SetAlpha(0.0f);
            Ans2.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer28 != 1)
        {
            Ans3.canvasRenderer.SetAlpha(0.0f);
            Ans4.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer29 != 1)
        {
            Ans5.canvasRenderer.SetAlpha(0.0f);
            Ans6.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer30 != 1)
        {
            Ans7.canvasRenderer.SetAlpha(0.0f);
            Ans8.canvasRenderer.SetAlpha(0.0f);
        }
        if (answer31 != 1)
        {
            Ans9.canvasRenderer.SetAlpha(0.0f);
            Ans10.canvasRenderer.SetAlpha(0.0f);
            Ans11.canvasRenderer.SetAlpha(0.0f);
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
                PlayerPrefs.SetInt("Answer27", 1);
                if (PlayerPrefs.GetInt("Answer27Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer27Correct", 1);
                    PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
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
                PlayerPrefs.SetInt("Answer28", 1);
                if (PlayerPrefs.GetInt("Answer28Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer28Correct", 1);
                    PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
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
                PlayerPrefs.SetInt("Answer29", 1);
                if (PlayerPrefs.GetInt("Answer29Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer29Correct", 1);
                    PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
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
                PlayerPrefs.SetInt("Answer30", 1);
                if (PlayerPrefs.GetInt("Answer30Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer30Correct", 1);
                    PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
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
                Ans9.CrossFadeAlpha(1, 2, false);
                Ans10.CrossFadeAlpha(1, 2, false);
                Ans11.CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer31", 1);
                if (PlayerPrefs.GetInt("Answer31Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer31Correct", 1);
                    PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 7)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 7);
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
        if (PlayerPrefs.GetInt("Round6Complete") == 5)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round6Complete", 6);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round6Complete") == 6)
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
        if (PlayerPrefs.GetInt("Answer27Correct") == 1)
        {
            Ans1.CrossFadeAlpha(1, 2, false);
            Ans2.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer28Correct") == 1)
        {
            Ans3.CrossFadeAlpha(1, 2, false);
            Ans4.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer29Correct") == 1)
        {
            Ans5.CrossFadeAlpha(1, 2, false);
            Ans6.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer30Correct") == 1)
        {
            Ans7.CrossFadeAlpha(1, 2, false);
            Ans8.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer31Correct") == 1)
        {
            Ans9.CrossFadeAlpha(1, 2, false);
            Ans10.CrossFadeAlpha(1, 2, false);
            Ans11.CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 7)
        {
            if (PlayerPrefs.GetInt("levelSixUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelSixUnlocked", 1);
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

    public void HintLevelSix()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer27Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer27", 1);
                PlayerPrefs.SetInt("Answer27Correct", 1);
                PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer28Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer28", 1);
                    PlayerPrefs.SetInt("Answer28Correct", 1);
                    PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer29Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer29", 1);
                        PlayerPrefs.SetInt("Answer29Correct", 1);
                        PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        //PlayerPrefs.SetInt("levelUnlocked", 2);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer30Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer30", 1);
                            PlayerPrefs.SetInt("Answer30Correct", 1);
                            PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            //PlayerPrefs.SetInt("levelUnlocked", 6);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer31Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer31", 1);
                                PlayerPrefs.SetInt("Answer31Correct", 1);
                                PlayerPrefs.SetInt("Round6Complete", PlayerPrefs.GetInt("Round6Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 7)
                                {
                                    PlayerPrefs.SetInt("levelUnlocked", 7);
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
