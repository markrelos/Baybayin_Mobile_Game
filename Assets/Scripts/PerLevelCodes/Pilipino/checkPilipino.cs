using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkPilipino : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3, Tile4;
    [SerializeField]
    Image[] Ans;
    [SerializeField]
    Animator coinsOneAnimation, coinsTwoAnimation, coinsFiveAnimation, congratsAnimation, hintAnimation, successAnim, newLvlAnim, perfectAnim, otherAnim;
    [SerializeField]
    GameObject coinsPanelOne, coinsPanelTwo, coinsPanelFive, congratsPanel, ansPanel, nextButton, tilePanel, hintPanel, successPanel, newLvlPanel, perfectPanel, otherPanel;
    [SerializeField]
    AudioSource correctSound, wrongSound;
    // Start is called before the first frame update
    void Start()
    {
        coinsPanelOne.SetActive(false);
        coinsPanelTwo.SetActive(false);
        coinsPanelFive.SetActive(false);
        nextButton.SetActive(false);
        hintPanel.SetActive(false);
        successPanel.SetActive(false);
        newLvlPanel.SetActive(false);
        perfectPanel.SetActive(false);
        otherPanel.SetActive(false);
        int answer32 = PlayerPrefs.GetInt("Answer32", 0);
        int answer33 = PlayerPrefs.GetInt("Answer33", 0);
        int answer34 = PlayerPrefs.GetInt("Answer34", 0);
        int answer35 = PlayerPrefs.GetInt("Answer35", 0);
        int answer36 = PlayerPrefs.GetInt("Answer36", 0);
        int answer37 = PlayerPrefs.GetInt("Answer37", 0);
        int answer38 = PlayerPrefs.GetInt("Answer38", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 7)
        {
            nextButton.SetActive(true);
        }

        if (answer32 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
            Ans[1].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer33 != 1)
        {
            Ans[2].canvasRenderer.SetAlpha(0.0f);
            Ans[3].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer34 != 1)
        {
            Ans[4].canvasRenderer.SetAlpha(0.0f);
            Ans[5].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer35 != 1)
        {
            Ans[6].canvasRenderer.SetAlpha(0.0f);
            Ans[7].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer36 != 1)
        {
            Ans[8].canvasRenderer.SetAlpha(0.0f);
            Ans[9].canvasRenderer.SetAlpha(0.0f);
            Ans[10].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer37 != 1)
        {
            Ans[11].canvasRenderer.SetAlpha(0.0f);
            Ans[12].canvasRenderer.SetAlpha(0.0f);
            Ans[13].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer38 != 1)
        {
            Ans[14].canvasRenderer.SetAlpha(0.0f);
            Ans[15].canvasRenderer.SetAlpha(0.0f);
            Ans[16].canvasRenderer.SetAlpha(0.0f);
            Ans[17].canvasRenderer.SetAlpha(0.0f);
        }
    }

    public void checkAnswers()
    {
        if (parent.childCount == 2)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile2)
            {
                Ans[0].CrossFadeAlpha(1, 2, false);
                Ans[1].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer32", 1);
                if (PlayerPrefs.GetInt("Answer32Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer32Correct", 1);
                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile1)
            {
                Ans[2].CrossFadeAlpha(1, 2, false);
                Ans[3].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer33", 1);
                if (PlayerPrefs.GetInt("Answer33Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer33Correct", 1);
                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile4 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[4].CrossFadeAlpha(1, 2, false);
                Ans[5].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer34", 1);
                if (PlayerPrefs.GetInt("Answer34Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer34Correct", 1);
                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1 || parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile3)
            {
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer35", 1);
                if (PlayerPrefs.GetInt("Answer35Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer35Correct", 1);
                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
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
                Tile4.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 3)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile4 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[8].CrossFadeAlpha(1, 2, false);
                Ans[9].CrossFadeAlpha(1, 2, false);
                Ans[10].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer36", 1);
                if (PlayerPrefs.GetInt("Answer36Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer36Correct", 1);
                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile2 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile2)
            {
                Ans[11].CrossFadeAlpha(1, 2, false);
                Ans[12].CrossFadeAlpha(1, 2, false);
                Ans[13].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer37", 1);
                if (PlayerPrefs.GetInt("Answer37Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer37Correct", 1);
                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
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
                Tile4.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }

        }
        else if (parent.childCount == 4)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile4 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile1 && parent.transform.GetChild(3) == Tile4)
            {
                Ans[14].CrossFadeAlpha(1, 2, false);
                Ans[15].CrossFadeAlpha(1, 2, false);
                Ans[16].CrossFadeAlpha(1, 2, false);
                Ans[17].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer38", 1);
                if (PlayerPrefs.GetInt("Answer38Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer38Correct", 1);
                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 8)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 8);
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }

        }

        else
        {
            Tile1.transform.SetParent(parentToReturnTo);
            Tile2.transform.SetParent(parentToReturnTo);
            Tile3.transform.SetParent(parentToReturnTo);
            Tile4.transform.SetParent(parentToReturnTo);
            wrongSound.Play();
            Debug.Log("Return");
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Round7Complete") == 7)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round7Complete", 8);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round7Complete") == 8)
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
        if (PlayerPrefs.GetInt("Answer32Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
            Ans[1].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer33Correct") == 1)
        {
            Ans[2].CrossFadeAlpha(1, 2, false);
            Ans[3].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer34Correct") == 1)
        {
            Ans[4].CrossFadeAlpha(1, 2, false);
            Ans[5].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer35Correct") == 1)
        {
            Ans[6].CrossFadeAlpha(1, 2, false);
            Ans[7].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer36Correct") == 1)
        {
            Ans[8].CrossFadeAlpha(1, 2, false);
            Ans[9].CrossFadeAlpha(1, 2, false);
            Ans[10].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer37Correct") == 1)
        {
            Ans[11].CrossFadeAlpha(1, 2, false);
            Ans[12].CrossFadeAlpha(1, 2, false);
            Ans[13].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer38Correct") == 1)
        {
            Ans[14].CrossFadeAlpha(1, 2, false);
            Ans[15].CrossFadeAlpha(1, 2, false);
            Ans[16].CrossFadeAlpha(1, 2, false);
            Ans[17].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 8)
        {
            if (PlayerPrefs.GetInt("levelSevenUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelSevenUnlocked", 1);
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
    IEnumerator coinsTwoPanel()
    {
        coinsPanelTwo.SetActive(true);
        coinsTwoAnimation.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        coinsPanelTwo.SetActive(false);
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

    public void HintLevelSeven()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer32Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer32", 1);
                PlayerPrefs.SetInt("Answer32Correct", 1);
                PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer33Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer33", 1);
                    PlayerPrefs.SetInt("Answer33Correct", 1);
                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer34Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer34", 1);
                        PlayerPrefs.SetInt("Answer34Correct", 1);
                        PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        //PlayerPrefs.SetInt("levelUnlocked", 2);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer35Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer35", 1);
                            PlayerPrefs.SetInt("Answer35Correct", 1);
                            PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            //PlayerPrefs.SetInt("levelUnlocked", 6);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer36Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer36", 1);
                                PlayerPrefs.SetInt("Answer36Correct", 1);
                                PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer37Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer37", 1);
                                    PlayerPrefs.SetInt("Answer37Correct", 1);
                                    PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    hintPanel.SetActive(false);
                                    correctSound.Play();
                                }
                                else
                                {
                                    if (PlayerPrefs.GetInt("Answer38Correct") == 0)
                                    {
                                        PlayerPrefs.SetInt("Answer38", 1);
                                        PlayerPrefs.SetInt("Answer38Correct", 1);
                                        PlayerPrefs.SetInt("Round7Complete", PlayerPrefs.GetInt("Round7Complete") + 1);
                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                        if (PlayerPrefs.GetInt("levelUnlocked", 0) < 8)
                                        {
                                            PlayerPrefs.SetInt("levelUnlocked", 8);
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
