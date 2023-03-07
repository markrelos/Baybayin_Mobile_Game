using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkBinibini : MonoBehaviour
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
        int answer39 = PlayerPrefs.GetInt("Answer39", 0);
        int answer40 = PlayerPrefs.GetInt("Answer40", 0);
        int answer41 = PlayerPrefs.GetInt("Answer41", 0);
        int answer42 = PlayerPrefs.GetInt("Answer42", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 8)
        {
            nextButton.SetActive(true);
        }

        if (answer39 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
            Ans[1].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer40 != 1)
        {
            Ans[2].canvasRenderer.SetAlpha(0.0f);
            Ans[3].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer41 != 1)
        {
            Ans[4].canvasRenderer.SetAlpha(0.0f);
            Ans[5].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer42 != 1)
        {
            Ans[6].canvasRenderer.SetAlpha(0.0f);
            Ans[7].canvasRenderer.SetAlpha(0.0f);
            Ans[8].canvasRenderer.SetAlpha(0.0f);
            Ans[9].canvasRenderer.SetAlpha(0.0f);
        }
    }

    public void checkAnswers()
    {
        if (parent.childCount == 2)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 || parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile4 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile2 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[0].CrossFadeAlpha(1, 2, false);
                Ans[1].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer39", 1);
                if (PlayerPrefs.GetInt("Answer39Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer39Correct", 1);
                    PlayerPrefs.SetInt("Round8Complete", PlayerPrefs.GetInt("Round8Complete") + 1);
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
                PlayerPrefs.SetInt("Answer40", 1);
                if (PlayerPrefs.GetInt("Answer40Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer40Correct", 1);
                    PlayerPrefs.SetInt("Round8Complete", PlayerPrefs.GetInt("Round8Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile4 || parent.transform.GetChild(0) == Tile4 && parent.transform.GetChild(1) == Tile2)
            {
                Ans[4].CrossFadeAlpha(1, 2, false);
                Ans[5].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer41", 1);
                if (PlayerPrefs.GetInt("Answer41Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer41Correct", 1);
                    PlayerPrefs.SetInt("Round8Complete", PlayerPrefs.GetInt("Round8Complete") + 1);
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
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile4 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile1 && parent.transform.GetChild(3) == Tile4 || parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile4 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile2 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile4 && parent.transform.GetChild(2) == Tile1 && parent.transform.GetChild(3) == Tile2)
            {
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Ans[8].CrossFadeAlpha(1, 2, false);
                Ans[9].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer42", 1);
                if (PlayerPrefs.GetInt("Answer42Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer42Correct", 1);
                    PlayerPrefs.SetInt("Round8Complete", PlayerPrefs.GetInt("Round8Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 9)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 9);
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
        if (PlayerPrefs.GetInt("Round8Complete") == 4)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round8Complete", 5);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round8Complete") == 5)
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
        if (PlayerPrefs.GetInt("Answer39Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
            Ans[1].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer40Correct") == 1)
        {
            Ans[2].CrossFadeAlpha(1, 2, false);
            Ans[3].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer41Correct") == 1)
        {
            Ans[4].CrossFadeAlpha(1, 2, false);
            Ans[5].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer42Correct") == 1)
        {
            Ans[6].CrossFadeAlpha(1, 2, false);
            Ans[7].CrossFadeAlpha(1, 2, false);
            Ans[8].CrossFadeAlpha(1, 2, false);
            Ans[9].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 9)
        {
            if (PlayerPrefs.GetInt("levelEightUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelEightUnlocked", 1);
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

    public void HintLevelEight()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {        
                if (PlayerPrefs.GetInt("Answer39Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer39", 1);
                    PlayerPrefs.SetInt("Answer39Correct", 1);
                    PlayerPrefs.SetInt("Round8Complete", PlayerPrefs.GetInt("Round8Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer40Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer40", 1);
                        PlayerPrefs.SetInt("Answer40Correct", 1);
                        PlayerPrefs.SetInt("Round8Complete", PlayerPrefs.GetInt("Round8Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        //PlayerPrefs.SetInt("levelUnlocked", 2);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer41Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer41", 1);
                            PlayerPrefs.SetInt("Answer41Correct", 1);
                            PlayerPrefs.SetInt("Round8Complete", PlayerPrefs.GetInt("Round8Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            //PlayerPrefs.SetInt("levelUnlocked", 6);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer42Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer42", 1);
                                PlayerPrefs.SetInt("Answer42Correct", 1);
                                PlayerPrefs.SetInt("Round8Complete", PlayerPrefs.GetInt("Round8Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            if (PlayerPrefs.GetInt("levelUnlocked", 0) < 9)
                            {
                                PlayerPrefs.SetInt("levelUnlocked", 9);
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
