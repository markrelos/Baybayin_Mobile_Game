using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkSaranggola : MonoBehaviour
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
        int answer73 = PlayerPrefs.GetInt("Answer73", 0);
        int answer74 = PlayerPrefs.GetInt("Answer74", 0);
        int answer75 = PlayerPrefs.GetInt("Answer75", 0);
        int answer76 = PlayerPrefs.GetInt("Answer76", 0);
        int answer77 = PlayerPrefs.GetInt("Answer77", 0);
        int answer78 = PlayerPrefs.GetInt("Answer78", 0);
        int answer79 = PlayerPrefs.GetInt("Answer79", 0);
        int answer80 = PlayerPrefs.GetInt("Answer80", 0);
        int answer81 = PlayerPrefs.GetInt("Answer81", 0);
        int answer82 = PlayerPrefs.GetInt("Answer82", 0);
        int answer83 = PlayerPrefs.GetInt("Answer83", 0);
        int answer84 = PlayerPrefs.GetInt("Answer84", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 13)
        {
            nextButton.SetActive(true);
        }

        if (answer73 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
            Ans[1].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer74 != 1)
        {
            Ans[2].canvasRenderer.SetAlpha(0.0f);
            Ans[3].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer75 != 1)
        {
            Ans[4].canvasRenderer.SetAlpha(0.0f);
            Ans[5].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer76 != 1)
        {
            Ans[6].canvasRenderer.SetAlpha(0.0f);
            Ans[7].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer77 != 1)
        {
            Ans[8].canvasRenderer.SetAlpha(0.0f);
            Ans[9].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer78 != 1)
        {
            Ans[10].canvasRenderer.SetAlpha(0.0f);
            Ans[11].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer79 != 1)
        {
            Ans[12].canvasRenderer.SetAlpha(0.0f);
            Ans[13].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer80 != 1)
        {
            Ans[14].canvasRenderer.SetAlpha(0.0f);
            Ans[15].canvasRenderer.SetAlpha(0.0f);
            Ans[16].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer81 != 1)
        {
            Ans[17].canvasRenderer.SetAlpha(0.0f);
            Ans[18].canvasRenderer.SetAlpha(0.0f);
            Ans[19].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer82 != 1)
        {
            Ans[20].canvasRenderer.SetAlpha(0.0f);
            Ans[21].canvasRenderer.SetAlpha(0.0f);
            Ans[22].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer83 != 1)
        {
            Ans[23].canvasRenderer.SetAlpha(0.0f);
            Ans[24].canvasRenderer.SetAlpha(0.0f);
            Ans[25].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer84 != 1)
        {
            Ans[26].canvasRenderer.SetAlpha(0.0f);
            Ans[27].canvasRenderer.SetAlpha(0.0f);
            Ans[28].canvasRenderer.SetAlpha(0.0f);
            Ans[29].canvasRenderer.SetAlpha(0.0f);
            Ans[30].canvasRenderer.SetAlpha(0.0f);
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
                PlayerPrefs.SetInt("Answer73", 1);
                if (PlayerPrefs.GetInt("Answer73Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer73Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
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
                Ans[2].CrossFadeAlpha(1, 2, false);
                Ans[3].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer74", 1);
                if (PlayerPrefs.GetInt("Answer74Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer74Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile5)
            {
                Ans[4].CrossFadeAlpha(1, 2, false);
                Ans[5].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer75", 1);
                if (PlayerPrefs.GetInt("Answer75Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer75Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile4 && parent.transform.GetChild(1) == Tile2)
            {
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer76", 1);
                if (PlayerPrefs.GetInt("Answer76Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer76Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile4 && parent.transform.GetChild(1) == Tile3)
            {
                Ans[8].CrossFadeAlpha(1, 2, false);
                Ans[9].CrossFadeAlpha(1, 2, false);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer77", 1);
                if (PlayerPrefs.GetInt("Answer77Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer77Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile5 && parent.transform.GetChild(1) == Tile1)
            {
                Ans[10].CrossFadeAlpha(1, 2, false);
                Ans[11].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer78", 1);
                if (PlayerPrefs.GetInt("Answer78Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer78Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile5 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[12].CrossFadeAlpha(1, 2, false);
                Ans[13].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer79", 1);
                if (PlayerPrefs.GetInt("Answer79Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer79Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
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
        else if (parent.childCount == 3)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3)
            {
                Ans[14].CrossFadeAlpha(1, 2, false);
                Ans[15].CrossFadeAlpha(1, 2, false);
                Ans[16].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer80", 1);
                if (PlayerPrefs.GetInt("Answer80Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer80Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile5)
            {
                Ans[17].CrossFadeAlpha(1, 2, false);
                Ans[18].CrossFadeAlpha(1, 2, false);
                Ans[19].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer81", 1);
                if (PlayerPrefs.GetInt("Answer81Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer81Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[20].CrossFadeAlpha(1, 2, false);
                Ans[21].CrossFadeAlpha(1, 2, false);
                Ans[22].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer82", 1);
                if (PlayerPrefs.GetInt("Answer82Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer82Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile5 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3)
            {
                Ans[23].CrossFadeAlpha(1, 2, false);
                Ans[24].CrossFadeAlpha(1, 2, false);
                Ans[25].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer83", 1);
                if (PlayerPrefs.GetInt("Answer83Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer83Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
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
                Ans[26].CrossFadeAlpha(1, 2, false);
                Ans[27].CrossFadeAlpha(1, 2, false);
                Ans[28].CrossFadeAlpha(1, 2, false);
                Ans[29].CrossFadeAlpha(1, 2, false);
                Ans[30].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer84", 1);
                if (PlayerPrefs.GetInt("Answer84Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer84Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 14)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 14);
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
        if (PlayerPrefs.GetInt("Round13Complete") == 12)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round13Complete", 13);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round13Complete") == 13)
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
        if (PlayerPrefs.GetInt("Answer73Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
            Ans[1].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer74Correct") == 1)
        {
            Ans[2].CrossFadeAlpha(1, 2, false);
            Ans[3].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer75Correct") == 1)
        {
            Ans[4].CrossFadeAlpha(1, 2, false);
            Ans[5].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer76Correct") == 1)
        {
            Ans[6].CrossFadeAlpha(1, 2, false);
            Ans[7].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer77Correct") == 1)
        {
            Ans[8].CrossFadeAlpha(1, 2, false);
            Ans[9].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer78Correct") == 1)
        {
            Ans[10].CrossFadeAlpha(1, 2, false);
            Ans[11].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer79Correct") == 1)
        {
            Ans[12].CrossFadeAlpha(1, 2, false);
            Ans[13].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer80Correct") == 1)
        {
            Ans[14].CrossFadeAlpha(1, 2, false);
            Ans[15].CrossFadeAlpha(1, 2, false);
            Ans[16].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer81Correct") == 1)
        {
            Ans[17].CrossFadeAlpha(1, 2, false);
            Ans[18].CrossFadeAlpha(1, 2, false);
            Ans[19].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer82Correct") == 1)
        {
            Ans[20].CrossFadeAlpha(1, 2, false);
            Ans[21].CrossFadeAlpha(1, 2, false);
            Ans[22].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer83Correct") == 1)
        {
            Ans[23].CrossFadeAlpha(1, 2, false);
            Ans[24].CrossFadeAlpha(1, 2, false);
            Ans[25].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer84Correct") == 1)
        {
            Ans[26].CrossFadeAlpha(1, 2, false);
            Ans[27].CrossFadeAlpha(1, 2, false);
            Ans[28].CrossFadeAlpha(1, 2, false);
            Ans[29].CrossFadeAlpha(1, 2, false);
            Ans[30].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 14)
        {
            if (PlayerPrefs.GetInt("levelThirteenUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelThirteenUnlocked", 1);
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

    public void HintLevelThirteen()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer73Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer73", 1);
                PlayerPrefs.SetInt("Answer73Correct", 1);
                PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer74Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer74", 1);
                    PlayerPrefs.SetInt("Answer74Correct", 1);
                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer75Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer75", 1);
                        PlayerPrefs.SetInt("Answer75Correct", 1);
                        PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer76Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer76", 1);
                            PlayerPrefs.SetInt("Answer76Correct", 1);
                            PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer77Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer77", 1);
                                PlayerPrefs.SetInt("Answer77Correct", 1);
                                PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer78Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer78", 1);
                                    PlayerPrefs.SetInt("Answer78Correct", 1);
                                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    hintPanel.SetActive(false);
                                    correctSound.Play();
                                }
                                else
                                {

                                    if (PlayerPrefs.GetInt("Answer79Correct") == 0)
                                    {
                                        PlayerPrefs.SetInt("Answer79", 1);
                                        PlayerPrefs.SetInt("Answer79Correct", 1);
                                        PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                        hintPanel.SetActive(false);
                                        correctSound.Play();
                                    }
                                    else
                                    {

                                        if (PlayerPrefs.GetInt("Answer80Correct") == 0)
                                        {
                                            PlayerPrefs.SetInt("Answer80", 1);
                                            PlayerPrefs.SetInt("Answer80Correct", 1);
                                            PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                            hintPanel.SetActive(false);
                                            correctSound.Play();
                                        }
                                        else
                                        {


                                            if (PlayerPrefs.GetInt("Answer81Correct") == 0)
                                            {
                                                PlayerPrefs.SetInt("Answer81", 1);
                                                PlayerPrefs.SetInt("Answer81Correct", 1);
                                                PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                hintPanel.SetActive(false);
                                                correctSound.Play();
                                            }
                                            else
                                            {
                                                if (PlayerPrefs.GetInt("Answer82Correct") == 0)
                                                {
                                                    PlayerPrefs.SetInt("Answer82", 1);
                                                    PlayerPrefs.SetInt("Answer82Correct", 1);
                                                    PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                    hintPanel.SetActive(false);
                                                    correctSound.Play();
                                                }
                                                else
                                                {
                                                    if (PlayerPrefs.GetInt("Answer83Correct") == 0)
                                                    {
                                                        PlayerPrefs.SetInt("Answer83", 1);
                                                        PlayerPrefs.SetInt("Answer83Correct", 1);
                                                        PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                        hintPanel.SetActive(false);
                                                        correctSound.Play();
                                                    }
                                                    else
                                                    {
                                                        if (PlayerPrefs.GetInt("Answer84Correct") == 0)
                                                        {
                                                            PlayerPrefs.SetInt("Answer84", 1);
                                                            PlayerPrefs.SetInt("Answer84Correct", 1);
                                                            PlayerPrefs.SetInt("Round13Complete", PlayerPrefs.GetInt("Round13Complete") + 1);
                                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                            if (PlayerPrefs.GetInt("levelUnlocked", 0) < 14)
                                                            {
                                                                PlayerPrefs.SetInt("levelUnlocked", 14);
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
