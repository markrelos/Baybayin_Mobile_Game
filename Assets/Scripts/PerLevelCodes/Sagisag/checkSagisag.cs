using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkSagisag : MonoBehaviour
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
        int answer48 = PlayerPrefs.GetInt("Answer48", 0);
        int answer49 = PlayerPrefs.GetInt("Answer49", 0);
        int answer50 = PlayerPrefs.GetInt("Answer50", 0);
        int answer51 = PlayerPrefs.GetInt("Answer51", 0);
        int answer52 = PlayerPrefs.GetInt("Answer52", 0);
        int answer53 = PlayerPrefs.GetInt("Answer53", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 10)
        {
            nextButton.SetActive(true);
        }

        if (answer48 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
            Ans[1].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer49 != 1)
        {
            Ans[2].canvasRenderer.SetAlpha(0.0f);
            Ans[3].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer50 != 1)
        {
            Ans[4].canvasRenderer.SetAlpha(0.0f);
            Ans[5].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer51 != 1)
        {
            Ans[6].canvasRenderer.SetAlpha(0.0f);
            Ans[7].canvasRenderer.SetAlpha(0.0f);
            Ans[8].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer52 != 1)
        {
            Ans[9].canvasRenderer.SetAlpha(0.0f);
            Ans[10].canvasRenderer.SetAlpha(0.0f);
            Ans[11].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer53 != 1)
        {
            Ans[12].canvasRenderer.SetAlpha(0.0f);
            Ans[13].canvasRenderer.SetAlpha(0.0f);
            Ans[14].canvasRenderer.SetAlpha(0.0f);
            Ans[15].canvasRenderer.SetAlpha(0.0f);
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
                PlayerPrefs.SetInt("Answer48", 1);
                if (PlayerPrefs.GetInt("Answer48Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer48Correct", 1);
                    PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
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
                PlayerPrefs.SetInt("Answer49", 1);
                if (PlayerPrefs.GetInt("Answer49Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer49Correct", 1);
                    PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
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
                Ans[4].CrossFadeAlpha(1, 2, false);
                Ans[5].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer50", 1);
                if (PlayerPrefs.GetInt("Answer50Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer50Correct", 1);
                    PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
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
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile2 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile2)
            {
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Ans[8].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer51", 1);
                if (PlayerPrefs.GetInt("Answer51Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer51Correct", 1);
                    PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile4 || parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[9].CrossFadeAlpha(1, 2, false);
                Ans[10].CrossFadeAlpha(1, 2, false);
                Ans[11].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer52", 1);
                if (PlayerPrefs.GetInt("Answer52Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer52Correct", 1);
                    PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
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
                Ans[12].CrossFadeAlpha(1, 2, false);
                Ans[13].CrossFadeAlpha(1, 2, false);
                Ans[14].CrossFadeAlpha(1, 2, false);
                Ans[15].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer53", 1);
                if (PlayerPrefs.GetInt("Answer53Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer53Correct", 1);
                    PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 11)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 11);
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
        if (PlayerPrefs.GetInt("Round10Complete") == 6)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round10Complete", 7);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round10Complete") == 7)
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
        if (PlayerPrefs.GetInt("Answer48Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
            Ans[1].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer49Correct") == 1)
        {
            Ans[2].CrossFadeAlpha(1, 2, false);
            Ans[3].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer50Correct") == 1)
        {
            Ans[4].CrossFadeAlpha(1, 2, false);
            Ans[5].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer51Correct") == 1)
        {
            Ans[6].CrossFadeAlpha(1, 2, false);
            Ans[7].CrossFadeAlpha(1, 2, false);
            Ans[8].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer52Correct") == 1)
        {
            Ans[9].CrossFadeAlpha(1, 2, false);
            Ans[10].CrossFadeAlpha(1, 2, false);
            Ans[11].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer53Correct") == 1)
        {
            Ans[12].CrossFadeAlpha(1, 2, false);
            Ans[13].CrossFadeAlpha(1, 2, false);
            Ans[14].CrossFadeAlpha(1, 2, false);
            Ans[15].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 11)
        {
            if (PlayerPrefs.GetInt("levelTenUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelTenUnlocked", 1);
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

    public void HintLevelTen()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer48Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer48", 1);
                PlayerPrefs.SetInt("Answer48Correct", 1);
                PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer49Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer49", 1);
                    PlayerPrefs.SetInt("Answer49Correct", 1);
                    PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer50Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer50", 1);
                        PlayerPrefs.SetInt("Answer50Correct", 1);
                        PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer51Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer51", 1);
                            PlayerPrefs.SetInt("Answer51Correct", 1);
                            PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer52Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer52", 1);
                                PlayerPrefs.SetInt("Answer52Correct", 1);
                                PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                /*if (PlayerPrefs.GetInt("levelUnlocked", 0) < 10)
                                {
                                    PlayerPrefs.SetInt("levelUnlocked", 10);
                                }*/
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer53Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer53", 1);
                                    PlayerPrefs.SetInt("Answer53Correct", 1);
                                    PlayerPrefs.SetInt("Round10Complete", PlayerPrefs.GetInt("Round10Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    if (PlayerPrefs.GetInt("levelUnlocked", 0) < 11)
                                    {
                                        PlayerPrefs.SetInt("levelUnlocked", 11);
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
