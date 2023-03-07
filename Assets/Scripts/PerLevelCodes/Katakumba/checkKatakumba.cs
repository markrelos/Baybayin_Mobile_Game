using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkKatakumba : MonoBehaviour
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
        int answer85 = PlayerPrefs.GetInt("Answer85", 0);
        int answer86 = PlayerPrefs.GetInt("Answer86", 0);
        int answer87 = PlayerPrefs.GetInt("Answer87", 0);
        int answer88 = PlayerPrefs.GetInt("Answer88", 0);
        int answer89 = PlayerPrefs.GetInt("Answer89", 0);
        int answer90 = PlayerPrefs.GetInt("Answer90", 0);
        int answer91 = PlayerPrefs.GetInt("Answer91", 0);
        int answer92 = PlayerPrefs.GetInt("Answer92", 0);
        int answer93 = PlayerPrefs.GetInt("Answer93", 0);
        int answer94 = PlayerPrefs.GetInt("Answer94", 0);
        int answer95 = PlayerPrefs.GetInt("Answer95", 0);
        int answer96 = PlayerPrefs.GetInt("Answer96", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 14)
        {
            nextButton.SetActive(true);
        }

        if (answer85 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
            Ans[1].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer86 != 1)
        {
            Ans[2].canvasRenderer.SetAlpha(0.0f);
            Ans[3].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer87 != 1)
        {
            Ans[4].canvasRenderer.SetAlpha(0.0f);
            Ans[5].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer88 != 1)
        {
            Ans[6].canvasRenderer.SetAlpha(0.0f);
            Ans[7].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer89 != 1)
        {
            Ans[8].canvasRenderer.SetAlpha(0.0f);
            Ans[9].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer90 != 1)
        {
            Ans[10].canvasRenderer.SetAlpha(0.0f);
            Ans[11].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer91 != 1)
        {
            Ans[12].canvasRenderer.SetAlpha(0.0f);
            Ans[13].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer92 != 1)
        {
            Ans[14].canvasRenderer.SetAlpha(0.0f);
            Ans[15].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer93 != 1)
        {
            Ans[16].canvasRenderer.SetAlpha(0.0f);
            Ans[17].canvasRenderer.SetAlpha(0.0f);
            Ans[18].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer94 != 1)
        {
            Ans[19].canvasRenderer.SetAlpha(0.0f);
            Ans[20].canvasRenderer.SetAlpha(0.0f);
            Ans[21].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer95 != 1)
        {
            Ans[22].canvasRenderer.SetAlpha(0.0f);
            Ans[23].canvasRenderer.SetAlpha(0.0f);
            Ans[24].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer96 != 1)
        {
            Ans[25].canvasRenderer.SetAlpha(0.0f);
            Ans[26].canvasRenderer.SetAlpha(0.0f);
            Ans[27].canvasRenderer.SetAlpha(0.0f);
            Ans[28].canvasRenderer.SetAlpha(0.0f);
            Ans[29].canvasRenderer.SetAlpha(0.0f);
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
                PlayerPrefs.SetInt("Answer85", 1);
                if (PlayerPrefs.GetInt("Answer85Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer85Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
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
                Ans[2].CrossFadeAlpha(1, 2, false);
                Ans[3].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer86", 1);
                if (PlayerPrefs.GetInt("Answer86Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer86Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
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
                Ans[4].CrossFadeAlpha(1, 2, false);
                Ans[5].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer87", 1);
                if (PlayerPrefs.GetInt("Answer87Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer87Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile5)
            {
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer88", 1);
                if (PlayerPrefs.GetInt("Answer88Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer88Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
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
                PlayerPrefs.SetInt("Answer89", 1);
                if (PlayerPrefs.GetInt("Answer89Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer89Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile5)
            {
                Ans[10].CrossFadeAlpha(1, 2, false);
                Ans[11].CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer90", 1);
                if (PlayerPrefs.GetInt("Answer90Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer90Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
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
                Ans[12].CrossFadeAlpha(1, 2, false);
                Ans[13].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer91", 1);
                if (PlayerPrefs.GetInt("Answer91Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer91Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile5 && parent.transform.GetChild(1) == Tile2)
            {
                Ans[14].CrossFadeAlpha(1, 2, false);
                Ans[15].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer92", 1);
                if (PlayerPrefs.GetInt("Answer92Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer92Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
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
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[16].CrossFadeAlpha(1, 2, false);
                Ans[17].CrossFadeAlpha(1, 2, false);
                Ans[18].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer93", 1);
                if (PlayerPrefs.GetInt("Answer93Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer93Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[19].CrossFadeAlpha(1, 2, false);
                Ans[20].CrossFadeAlpha(1, 2, false);
                Ans[21].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer94", 1);
                if (PlayerPrefs.GetInt("Answer94Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer94Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile5 && parent.transform.GetChild(2) == Tile2)
            {
                Ans[22].CrossFadeAlpha(1, 2, false);
                Ans[23].CrossFadeAlpha(1, 2, false);
                Ans[24].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer95", 1);
                if (PlayerPrefs.GetInt("Answer95Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer95Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
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
                Ans[25].CrossFadeAlpha(1, 2, false);
                Ans[26].CrossFadeAlpha(1, 2, false);
                Ans[27].CrossFadeAlpha(1, 2, false);
                Ans[28].CrossFadeAlpha(1, 2, false);
                Ans[29].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer96", 1);
                if (PlayerPrefs.GetInt("Answer96Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer96Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 15)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 15);
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
        if (PlayerPrefs.GetInt("Round14Complete") == 12)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round14Complete", 13);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round14Complete") == 13)
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
        if (PlayerPrefs.GetInt("Answer85Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
            Ans[1].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer86Correct") == 1)
        {
            Ans[2].CrossFadeAlpha(1, 2, false);
            Ans[3].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer87Correct") == 1)
        {
            Ans[4].CrossFadeAlpha(1, 2, false);
            Ans[5].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer88Correct") == 1)
        {
            Ans[6].CrossFadeAlpha(1, 2, false);
            Ans[7].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer89Correct") == 1)
        {
            Ans[8].CrossFadeAlpha(1, 2, false);
            Ans[9].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer90Correct") == 1)
        {
            Ans[10].CrossFadeAlpha(1, 2, false);
            Ans[11].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer91Correct") == 1)
        {
            Ans[12].CrossFadeAlpha(1, 2, false);
            Ans[13].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer92Correct") == 1)
        {
            Ans[14].CrossFadeAlpha(1, 2, false);
            Ans[15].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer93Correct") == 1)
        {
            Ans[16].CrossFadeAlpha(1, 2, false);
            Ans[17].CrossFadeAlpha(1, 2, false);
            Ans[18].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer94Correct") == 1)
        {
            Ans[19].CrossFadeAlpha(1, 2, false);
            Ans[20].CrossFadeAlpha(1, 2, false);
            Ans[21].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer95Correct") == 1)
        {
            Ans[22].CrossFadeAlpha(1, 2, false);
            Ans[23].CrossFadeAlpha(1, 2, false);
            Ans[24].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer96Correct") == 1)
        {
            Ans[25].CrossFadeAlpha(1, 2, false);
            Ans[26].CrossFadeAlpha(1, 2, false);
            Ans[27].CrossFadeAlpha(1, 2, false);
            Ans[28].CrossFadeAlpha(1, 2, false);
            Ans[29].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 15)
        {
            if (PlayerPrefs.GetInt("levelFourteenUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelFourteenUnlocked", 1);
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
    public void HintLevelFourteen()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer85Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer85", 1);
                PlayerPrefs.SetInt("Answer85Correct", 1);
                PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer86Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer86", 1);
                    PlayerPrefs.SetInt("Answer86Correct", 1);
                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer87Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer87", 1);
                        PlayerPrefs.SetInt("Answer87Correct", 1);
                        PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer88Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer88", 1);
                            PlayerPrefs.SetInt("Answer88Correct", 1);
                            PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer89Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer89", 1);
                                PlayerPrefs.SetInt("Answer89Correct", 1);
                                PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer90Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer90", 1);
                                    PlayerPrefs.SetInt("Answer90Correct", 1);
                                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    hintPanel.SetActive(false);
                                    correctSound.Play();
                                }
                                else
                                {

                                    if (PlayerPrefs.GetInt("Answer91Correct") == 0)
                                    {
                                        PlayerPrefs.SetInt("Answer91", 1);
                                        PlayerPrefs.SetInt("Answer91Correct", 1);
                                        PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                        hintPanel.SetActive(false);
                                        correctSound.Play();
                                    }
                                    else
                                    {

                                        if (PlayerPrefs.GetInt("Answer92Correct") == 0)
                                        {
                                            PlayerPrefs.SetInt("Answer92", 1);
                                            PlayerPrefs.SetInt("Answer92Correct", 1);
                                            PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                            hintPanel.SetActive(false);
                                            correctSound.Play();
                                        }
                                        else
                                        {


                                            if (PlayerPrefs.GetInt("Answer93Correct") == 0)
                                            {
                                                PlayerPrefs.SetInt("Answer93", 1);
                                                PlayerPrefs.SetInt("Answer93Correct", 1);
                                                PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                hintPanel.SetActive(false);
                                                correctSound.Play();
                                            }
                                            else
                                            {
                                                if (PlayerPrefs.GetInt("Answer94Correct") == 0)
                                                {
                                                    PlayerPrefs.SetInt("Answer94", 1);
                                                    PlayerPrefs.SetInt("Answer94Correct", 1);
                                                    PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                    hintPanel.SetActive(false);
                                                    correctSound.Play();
                                                }
                                                else
                                                {
                                                    if (PlayerPrefs.GetInt("Answer95Correct") == 0)
                                                    {
                                                        PlayerPrefs.SetInt("Answer95", 1);
                                                        PlayerPrefs.SetInt("Answer95Correct", 1);
                                                        PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                        hintPanel.SetActive(false);
                                                        correctSound.Play();
                                                    }
                                                    else
                                                    {
                                                        if (PlayerPrefs.GetInt("Answer96Correct") == 0)
                                                        {
                                                            PlayerPrefs.SetInt("Answer96", 1);
                                                            PlayerPrefs.SetInt("Answer96Correct", 1);
                                                            PlayerPrefs.SetInt("Round14Complete", PlayerPrefs.GetInt("Round14Complete") + 1);
                                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                            if (PlayerPrefs.GetInt("levelUnlocked", 0) < 15)
                                                            {
                                                                PlayerPrefs.SetInt("levelUnlocked", 15);
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
