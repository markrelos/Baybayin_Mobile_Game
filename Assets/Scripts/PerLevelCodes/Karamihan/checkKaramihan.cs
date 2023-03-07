using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class checkKaramihan : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3, Tile4, Tile5;
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
        int answer65 = PlayerPrefs.GetInt("Answer65", 0);
        int answer66 = PlayerPrefs.GetInt("Answer66", 0);
        int answer67 = PlayerPrefs.GetInt("Answer67", 0);
        int answer68 = PlayerPrefs.GetInt("Answer68", 0);
        int answer69 = PlayerPrefs.GetInt("Answer69", 0);
        int answer70 = PlayerPrefs.GetInt("Answer70", 0);
        int answer71 = PlayerPrefs.GetInt("Answer71", 0);
        int answer72 = PlayerPrefs.GetInt("Answer72", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 12)
        {
            nextButton.SetActive(true);
        }

        if (answer65 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
            Ans[1].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer66 != 1)
        {
            Ans[2].canvasRenderer.SetAlpha(0.0f);
            Ans[3].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer67 != 1)
        {
            Ans[4].canvasRenderer.SetAlpha(0.0f);
            Ans[5].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer68 != 1)
        {
            Ans[6].canvasRenderer.SetAlpha(0.0f);
            Ans[7].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer69 != 1)
        {
            Ans[8].canvasRenderer.SetAlpha(0.0f);
            Ans[9].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer70 != 1)
        {
            Ans[10].canvasRenderer.SetAlpha(0.0f);
            Ans[11].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer71 != 1)
        {
            Ans[12].canvasRenderer.SetAlpha(0.0f);
            Ans[13].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer72 != 1)
        {
            Ans[14].canvasRenderer.SetAlpha(0.0f);
            Ans[15].canvasRenderer.SetAlpha(0.0f);
            Ans[16].canvasRenderer.SetAlpha(0.0f);
            Ans[17].canvasRenderer.SetAlpha(0.0f);
            Ans[18].canvasRenderer.SetAlpha(0.0f);
        }
        
    }

    public void checkAnswers()
    {
        if (parent.childCount == 2)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2)
            {
                Ans[0].CrossFadeAlpha(1, 2, false);
                Ans[1].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer65", 1);
                if (PlayerPrefs.GetInt("Answer65Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer65Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
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
                Ans[2].CrossFadeAlpha(1, 2, false);
                Ans[3].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer66", 1);
                if (PlayerPrefs.GetInt("Answer66Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer66Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[4].CrossFadeAlpha(1, 2, false);
                Ans[5].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer67", 1);
                if (PlayerPrefs.GetInt("Answer67Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer67Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
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
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer68", 1);
                if (PlayerPrefs.GetInt("Answer68Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer68Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
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
                Ans[8].CrossFadeAlpha(1, 2, false);
                Ans[9].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer69", 1);
                if (PlayerPrefs.GetInt("Answer69Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer69Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[10].CrossFadeAlpha(1, 2, false);
                Ans[11].CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer70", 1);
                if (PlayerPrefs.GetInt("Answer70Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer70Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile4 && parent.transform.GetChild(1) == Tile1)
            {
                Ans[12].CrossFadeAlpha(1, 2, false);
                Ans[13].CrossFadeAlpha(1, 2, false);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer71", 1);
                if (PlayerPrefs.GetInt("Answer71Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer71Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
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
                Tile5.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        
        else if (parent.childCount == 5)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile4 && parent.transform.GetChild(4) == Tile5)
            {
                Ans[14].CrossFadeAlpha(1, 2, false);
                Ans[15].CrossFadeAlpha(1, 2, false);
                Ans[16].CrossFadeAlpha(1, 2, false);
                Ans[17].CrossFadeAlpha(1, 2, false);
                Ans[18].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer72", 1);
                if (PlayerPrefs.GetInt("Answer72Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer72Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 13)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 13);
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
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
            Tile5.transform.SetParent(parentToReturnTo);
            wrongSound.Play();
            Debug.Log("Return");
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Round12Complete") == 8)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round12Complete", 9);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round12Complete") == 9)
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
        if (PlayerPrefs.GetInt("Answer65Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
            Ans[1].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer66Correct") == 1)
        {
            Ans[2].CrossFadeAlpha(1, 2, false);
            Ans[3].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer67Correct") == 1)
        {
            Ans[4].CrossFadeAlpha(1, 2, false);
            Ans[5].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer68Correct") == 1)
        {
            Ans[6].CrossFadeAlpha(1, 2, false);
            Ans[7].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer69Correct") == 1)
        {
            Ans[8].CrossFadeAlpha(1, 2, false);
            Ans[9].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer70Correct") == 1)
        {
            Ans[10].CrossFadeAlpha(1, 2, false);
            Ans[11].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer71Correct") == 1)
        {
            Ans[12].CrossFadeAlpha(1, 2, false);
            Ans[13].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer72Correct") == 1)
        {
            Ans[14].CrossFadeAlpha(1, 2, false);
            Ans[15].CrossFadeAlpha(1, 2, false);
            Ans[16].CrossFadeAlpha(1, 2, false);
            Ans[17].CrossFadeAlpha(1, 2, false);
            Ans[18].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 13)
        {
            if (PlayerPrefs.GetInt("levelTwelveUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelTwelveUnlocked", 1);
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

    public void HintLevelTwelve()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer65Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer65", 1);
                PlayerPrefs.SetInt("Answer65Correct", 1);
                PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer66Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer66", 1);
                    PlayerPrefs.SetInt("Answer66Correct", 1);
                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer67Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer67", 1);
                        PlayerPrefs.SetInt("Answer67Correct", 1);
                        PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer68Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer68", 1);
                            PlayerPrefs.SetInt("Answer68Correct", 1);
                            PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer69Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer69", 1);
                                PlayerPrefs.SetInt("Answer69Correct", 1);
                                PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer70Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer70", 1);
                                    PlayerPrefs.SetInt("Answer70Correct", 1);
                                    PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    hintPanel.SetActive(false);
                                    correctSound.Play();
                                }
                                else
                                {

                                    if (PlayerPrefs.GetInt("Answer71Correct") == 0)
                                    {
                                        PlayerPrefs.SetInt("Answer71", 1);
                                        PlayerPrefs.SetInt("Answer71Correct", 1);
                                        PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                        hintPanel.SetActive(false);
                                        correctSound.Play();
                                    }
                                    else
                                    {

                                        if (PlayerPrefs.GetInt("Answer72Correct") == 0)
                                        {
                                            PlayerPrefs.SetInt("Answer72", 1);
                                            PlayerPrefs.SetInt("Answer72Correct", 1);
                                            PlayerPrefs.SetInt("Round12Complete", PlayerPrefs.GetInt("Round12Complete") + 1);
                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                            if (PlayerPrefs.GetInt("levelUnlocked", 0) < 13)
                                            {
                                                PlayerPrefs.SetInt("levelUnlocked", 13);
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
