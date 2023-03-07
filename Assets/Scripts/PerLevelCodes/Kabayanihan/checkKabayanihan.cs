using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkKabayanihan : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3, Tile4, Tile5, Tile6;
    [SerializeField]
    Image[] Ans;
    [SerializeField]
    Animator coinsOneAnimation, coinsTwoAnimation, coinsThreeAnimation, coinsFiveAnimation, congratsAnimation, hintAnimation, successAnim, /*newLvlAnim,*/ otherAnim, perfectAnim;
    [SerializeField]
    GameObject coinsPanelOne, coinsPanelTwo, coinsPanelThree, coinsPanelFive, congratsPanel, ansPanel, shuffleButton, tilePanel, hintPanel, /*successPanel, newLvlPanel,*/ otherPanel, perfectPanel, noticePanel;
    [SerializeField]
    AudioSource correctSound, wrongSound, correctLong;
    // Start is called before the first frame update
    void Start()
    {
        coinsPanelOne.SetActive(false);
        coinsPanelTwo.SetActive(false);
        coinsPanelThree.SetActive(false);
        coinsPanelFive.SetActive(false);
        //nextButton.SetActive(false);
        hintPanel.SetActive(false);
        congratsPanel.SetActive(false);
        otherPanel.SetActive(false);
        perfectPanel.SetActive(false);
        //successPanel.SetActive(false);
        //newLvlPanel.SetActive(false);
        int answer97 = PlayerPrefs.GetInt("Answer97", 0);
        int answer98 = PlayerPrefs.GetInt("Answer98", 0);
        int answer99 = PlayerPrefs.GetInt("Answer99", 0);
        int answer100 = PlayerPrefs.GetInt("Answer100", 0);
        int answer101 = PlayerPrefs.GetInt("Answer101", 0);
        int answer102 = PlayerPrefs.GetInt("Answer102", 0);
        int answer103 = PlayerPrefs.GetInt("Answer103", 0);
        int answer104 = PlayerPrefs.GetInt("Answer104", 0);
        int answer105 = PlayerPrefs.GetInt("Answer105", 0);
        int answer106 = PlayerPrefs.GetInt("Answer106", 0);
        int answer107 = PlayerPrefs.GetInt("Answer107", 0);
        int answer108 = PlayerPrefs.GetInt("Answer108", 0);
        int answer109 = PlayerPrefs.GetInt("Answer109", 0);
        int answer110 = PlayerPrefs.GetInt("Answer110", 0);
        int answer111 = PlayerPrefs.GetInt("Answer111", 0);
        int answer112 = PlayerPrefs.GetInt("Answer112", 0);
        int answer113 = PlayerPrefs.GetInt("Answer113", 0);
        int answer114 = PlayerPrefs.GetInt("Answer114", 0);
        int answer115 = PlayerPrefs.GetInt("Answer115", 0);
        int answer116 = PlayerPrefs.GetInt("Answer116", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        /*if (unlockLevel > 15)
        {
            nextButton.SetActive(true);
        }*/
        if (PlayerPrefs.GetInt("Round15Complete") >= 20)
        {
            noticePanel.SetActive(false);
        }

        if (answer97 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
            Ans[1].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer98 != 1)
        {
            Ans[2].canvasRenderer.SetAlpha(0.0f);
            Ans[3].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer99 != 1)
        {
            Ans[4].canvasRenderer.SetAlpha(0.0f);
            Ans[5].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer100 != 1)
        {
            Ans[6].canvasRenderer.SetAlpha(0.0f);
            Ans[7].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer101 != 1)
        {
            Ans[8].canvasRenderer.SetAlpha(0.0f);
            Ans[9].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer102 != 1)
        {
            Ans[10].canvasRenderer.SetAlpha(0.0f);
            Ans[11].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer103 != 1)
        {
            Ans[12].canvasRenderer.SetAlpha(0.0f);
            Ans[13].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer104 != 1)
        {
            Ans[14].canvasRenderer.SetAlpha(0.0f);
            Ans[15].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer105 != 1)
        {
            Ans[16].canvasRenderer.SetAlpha(0.0f);
            Ans[17].canvasRenderer.SetAlpha(0.0f);
            Ans[18].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer106 != 1)
        {
            Ans[19].canvasRenderer.SetAlpha(0.0f);
            Ans[20].canvasRenderer.SetAlpha(0.0f);
            Ans[21].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer107 != 1)
        {
            Ans[22].canvasRenderer.SetAlpha(0.0f);
            Ans[23].canvasRenderer.SetAlpha(0.0f);
            Ans[24].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer108 != 1)
        {
            Ans[25].canvasRenderer.SetAlpha(0.0f);
            Ans[26].canvasRenderer.SetAlpha(0.0f);
            Ans[27].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer109 != 1)
        {
            Ans[28].canvasRenderer.SetAlpha(0.0f);
            Ans[29].canvasRenderer.SetAlpha(0.0f);
            Ans[30].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer110 != 1)
        {
            Ans[31].canvasRenderer.SetAlpha(0.0f);
            Ans[32].canvasRenderer.SetAlpha(0.0f);
            Ans[33].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer111 != 1)
        {
            Ans[34].canvasRenderer.SetAlpha(0.0f);
            Ans[35].canvasRenderer.SetAlpha(0.0f);
            Ans[36].canvasRenderer.SetAlpha(0.0f);
            Ans[37].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer112 != 1)
        {
            Ans[38].canvasRenderer.SetAlpha(0.0f);
            Ans[39].canvasRenderer.SetAlpha(0.0f);
            Ans[40].canvasRenderer.SetAlpha(0.0f);
            Ans[41].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer113 != 1)
        {
            Ans[42].canvasRenderer.SetAlpha(0.0f);
            Ans[43].canvasRenderer.SetAlpha(0.0f);
            Ans[44].canvasRenderer.SetAlpha(0.0f);
            Ans[45].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer114 != 1)
        {
            Ans[46].canvasRenderer.SetAlpha(0.0f);
            Ans[47].canvasRenderer.SetAlpha(0.0f);
            Ans[48].canvasRenderer.SetAlpha(0.0f);
            Ans[49].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer115 != 1)
        {
            Ans[50].canvasRenderer.SetAlpha(0.0f);
            Ans[51].canvasRenderer.SetAlpha(0.0f);
            Ans[52].canvasRenderer.SetAlpha(0.0f);
            Ans[53].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer116 != 1)
        {
            Ans[54].canvasRenderer.SetAlpha(0.0f);
            Ans[55].canvasRenderer.SetAlpha(0.0f);
            Ans[56].canvasRenderer.SetAlpha(0.0f);
            Ans[57].canvasRenderer.SetAlpha(0.0f);
            Ans[58].canvasRenderer.SetAlpha(0.0f);
            Ans[59].canvasRenderer.SetAlpha(0.0f);
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
                PlayerPrefs.SetInt("Answer97", 1);
                if (PlayerPrefs.GetInt("Answer97Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer97Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                PlayerPrefs.SetInt("Answer98", 1);
                if (PlayerPrefs.GetInt("Answer98Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer98Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                PlayerPrefs.SetInt("Answer99", 1);
                if (PlayerPrefs.GetInt("Answer99Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer99Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer100", 1);
                if (PlayerPrefs.GetInt("Answer100Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer100Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                Ans[8].CrossFadeAlpha(1, 2, false);
                Ans[9].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer101", 1);
                if (PlayerPrefs.GetInt("Answer101Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer101Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                Tile1.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer102", 1);
                if (PlayerPrefs.GetInt("Answer102Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer102Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                Ans[12].CrossFadeAlpha(1, 2, false);
                Ans[13].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer103", 1);
                if (PlayerPrefs.GetInt("Answer103Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer103Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile5 && parent.transform.GetChild(1) == Tile3)
            {
                Ans[14].CrossFadeAlpha(1, 2, false);
                Ans[15].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer104", 1);
                if (PlayerPrefs.GetInt("Answer104Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer104Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                Tile6.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 3)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile6)
            {
                Ans[16].CrossFadeAlpha(1, 2, false);
                Ans[17].CrossFadeAlpha(1, 2, false);
                Ans[18].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer105", 1);
                if (PlayerPrefs.GetInt("Answer105Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer105Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile6)
            {
                Ans[19].CrossFadeAlpha(1, 2, false);
                Ans[20].CrossFadeAlpha(1, 2, false);
                Ans[21].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer106", 1);
                if (PlayerPrefs.GetInt("Answer106Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer106Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile4 && parent.transform.GetChild(2) == Tile6)
            {
                Ans[22].CrossFadeAlpha(1, 2, false);
                Ans[23].CrossFadeAlpha(1, 2, false);
                Ans[24].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer107", 1);
                if (PlayerPrefs.GetInt("Answer107Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer107Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile6)
            {
                Ans[25].CrossFadeAlpha(1, 2, false);
                Ans[26].CrossFadeAlpha(1, 2, false);
                Ans[27].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer108", 1);
                if (PlayerPrefs.GetInt("Answer108Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer108Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                Ans[28].CrossFadeAlpha(1, 2, false);
                Ans[29].CrossFadeAlpha(1, 2, false);
                Ans[30].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer109", 1);
                if (PlayerPrefs.GetInt("Answer109Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer109Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile5 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile6)
            {
                Ans[31].CrossFadeAlpha(1, 2, false);
                Ans[32].CrossFadeAlpha(1, 2, false);
                Ans[33].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer110", 1);
                if (PlayerPrefs.GetInt("Answer110Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer110Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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
                Tile6.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 4)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile6)
            {
                Ans[34].CrossFadeAlpha(1, 2, false);
                Ans[35].CrossFadeAlpha(1, 2, false);
                Ans[36].CrossFadeAlpha(1, 2, false);
                Ans[37].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer111", 1);
                if (PlayerPrefs.GetInt("Answer111Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer111Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile5 && parent.transform.GetChild(3) == Tile6)
            {
                Ans[38].CrossFadeAlpha(1, 2, false);
                Ans[39].CrossFadeAlpha(1, 2, false);
                Ans[40].CrossFadeAlpha(1, 2, false);
                Ans[41].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer112", 1);
                if (PlayerPrefs.GetInt("Answer112Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer112Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile6)
            {
                Ans[42].CrossFadeAlpha(1, 2, false);
                Ans[43].CrossFadeAlpha(1, 2, false);
                Ans[44].CrossFadeAlpha(1, 2, false);
                Ans[45].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer113", 1);
                if (PlayerPrefs.GetInt("Answer113Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer113Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile5 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile6)
            {
                Ans[46].CrossFadeAlpha(1, 2, false);
                Ans[47].CrossFadeAlpha(1, 2, false);
                Ans[48].CrossFadeAlpha(1, 2, false);
                Ans[49].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer114", 1);
                if (PlayerPrefs.GetInt("Answer114Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer114Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile1 && parent.transform.GetChild(3) == Tile6)
            {
                Ans[50].CrossFadeAlpha(1, 2, false);
                Ans[51].CrossFadeAlpha(1, 2, false);
                Ans[52].CrossFadeAlpha(1, 2, false);
                Ans[53].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer115", 1);
                if (PlayerPrefs.GetInt("Answer115Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer115Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
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
                Tile6.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }

        else if (parent.childCount == 6)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile4 && parent.transform.GetChild(4) == Tile5 && parent.transform.GetChild(5) == Tile6)
            {
                Ans[54].CrossFadeAlpha(1, 2, false);
                Ans[55].CrossFadeAlpha(1, 2, false);
                Ans[56].CrossFadeAlpha(1, 2, false);
                Ans[57].CrossFadeAlpha(1, 2, false);
                Ans[58].CrossFadeAlpha(1, 2, false);
                Ans[59].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                //nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer116", 1);
                if (PlayerPrefs.GetInt("Answer116Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer116Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    correctLong.Play();
                    StartCoroutine(coinsThreePanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 16)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 16);
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
                Tile6.transform.SetParent(parentToReturnTo);
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
            Tile6.transform.SetParent(parentToReturnTo);
            wrongSound.Play();
            Debug.Log("Return");
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Round15Complete") == 20)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round15Complete", 21);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round15Complete") == 21)
        {
            congratsPanel.SetActive(true);
            congratsAnimation.SetTrigger("Start");
            perfectPanel.SetActive(true);
            perfectAnim.SetTrigger("Start");
            otherPanel.SetActive(true);
            otherAnim.SetTrigger("Start");
            ansPanel.SetActive(false);
            shuffleButton.SetActive(false);
            //nextButton.SetActive(false);
            tilePanel.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Answer97Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
            Ans[1].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer98Correct") == 1)
        {
            Ans[2].CrossFadeAlpha(1, 2, false);
            Ans[3].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer99Correct") == 1)
        {
            Ans[4].CrossFadeAlpha(1, 2, false);
            Ans[5].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer100Correct") == 1)
        {
            Ans[6].CrossFadeAlpha(1, 2, false);
            Ans[7].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer101Correct") == 1)
        {
            Ans[8].CrossFadeAlpha(1, 2, false);
            Ans[9].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer102Correct") == 1)
        {
            Ans[10].CrossFadeAlpha(1, 2, false);
            Ans[11].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer103Correct") == 1)
        {
            Ans[12].CrossFadeAlpha(1, 2, false);
            Ans[13].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer104Correct") == 1)
        {
            Ans[14].CrossFadeAlpha(1, 2, false);
            Ans[15].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer105Correct") == 1)
        {
            Ans[16].CrossFadeAlpha(1, 2, false);
            Ans[17].CrossFadeAlpha(1, 2, false);
            Ans[18].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer106Correct") == 1)
        {
            Ans[19].CrossFadeAlpha(1, 2, false);
            Ans[20].CrossFadeAlpha(1, 2, false);
            Ans[21].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer107Correct") == 1)
        {
            Ans[22].CrossFadeAlpha(1, 2, false);
            Ans[23].CrossFadeAlpha(1, 2, false);
            Ans[24].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer108Correct") == 1)
        {
            Ans[25].CrossFadeAlpha(1, 2, false);
            Ans[26].CrossFadeAlpha(1, 2, false);
            Ans[27].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer109Correct") == 1)
        {
            Ans[28].CrossFadeAlpha(1, 2, false);
            Ans[29].CrossFadeAlpha(1, 2, false);
            Ans[30].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer110Correct") == 1)
        {
            Ans[31].CrossFadeAlpha(1, 2, false);
            Ans[32].CrossFadeAlpha(1, 2, false);
            Ans[33].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer111Correct") == 1)
        {
            Ans[34].CrossFadeAlpha(1, 2, false);
            Ans[35].CrossFadeAlpha(1, 2, false);
            Ans[36].CrossFadeAlpha(1, 2, false);
            Ans[37].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer112Correct") == 1)
        {
            Ans[38].CrossFadeAlpha(1, 2, false);
            Ans[39].CrossFadeAlpha(1, 2, false);
            Ans[40].CrossFadeAlpha(1, 2, false);
            Ans[41].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer113Correct") == 1)
        {
            Ans[42].CrossFadeAlpha(1, 2, false);
            Ans[43].CrossFadeAlpha(1, 2, false);
            Ans[44].CrossFadeAlpha(1, 2, false);
            Ans[45].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer114Correct") == 1)
        {
            Ans[46].CrossFadeAlpha(1, 2, false);
            Ans[47].CrossFadeAlpha(1, 2, false);
            Ans[48].CrossFadeAlpha(1, 2, false);
            Ans[49].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer115Correct") == 1)
        {
            Ans[50].CrossFadeAlpha(1, 2, false);
            Ans[51].CrossFadeAlpha(1, 2, false);
            Ans[52].CrossFadeAlpha(1, 2, false);
            Ans[53].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer116Correct") == 1)
        {
            Ans[54].CrossFadeAlpha(1, 2, false);
            Ans[55].CrossFadeAlpha(1, 2, false);
            Ans[56].CrossFadeAlpha(1, 2, false);
            Ans[57].CrossFadeAlpha(1, 2, false);
            Ans[58].CrossFadeAlpha(1, 2, false);
            Ans[59].CrossFadeAlpha(1, 2, false);
        }
        /*if (PlayerPrefs.GetInt("levelUnlocked") == 16)
        {
            if (PlayerPrefs.GetInt("levelFifteenUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelFifteenUnlocked", 1);
            }
        }*/
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
    IEnumerator coinsThreePanel()
    {
        coinsPanelThree.SetActive(true);
        coinsThreeAnimation.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        coinsPanelThree.SetActive(false);
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
    /*IEnumerator newLvlAnimation()
    {
        newLvlPanel.SetActive(true);
        newLvlAnim.SetTrigger("Start");
        yield return new WaitForSeconds(3f);
        newLvlPanel.SetActive(false);
    }*/

    public void HintLevelFifteen()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer97Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer97", 1);
                PlayerPrefs.SetInt("Answer97Correct", 1);
                PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer98Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer98", 1);
                    PlayerPrefs.SetInt("Answer98Correct", 1);
                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer99Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer99", 1);
                        PlayerPrefs.SetInt("Answer99Correct", 1);
                        PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer100Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer100", 1);
                            PlayerPrefs.SetInt("Answer100Correct", 1);
                            PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer101Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer101", 1);
                                PlayerPrefs.SetInt("Answer101Correct", 1);
                                PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer102Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer102", 1);
                                    PlayerPrefs.SetInt("Answer102Correct", 1);
                                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    hintPanel.SetActive(false);
                                    correctSound.Play();
                                }
                                else
                                {

                                    if (PlayerPrefs.GetInt("Answer103Correct") == 0)
                                    {
                                        PlayerPrefs.SetInt("Answer103", 1);
                                        PlayerPrefs.SetInt("Answer103Correct", 1);
                                        PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                        hintPanel.SetActive(false);
                                        correctSound.Play();
                                    }
                                    else
                                    {

                                        if (PlayerPrefs.GetInt("Answer104Correct") == 0)
                                        {
                                            PlayerPrefs.SetInt("Answer104", 1);
                                            PlayerPrefs.SetInt("Answer104Correct", 1);
                                            PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                            hintPanel.SetActive(false);
                                            correctSound.Play();
                                        }
                                        else
                                        {


                                            if (PlayerPrefs.GetInt("Answer105Correct") == 0)
                                            {
                                                PlayerPrefs.SetInt("Answer105", 1);
                                                PlayerPrefs.SetInt("Answer105Correct", 1);
                                                PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                hintPanel.SetActive(false);
                                                correctSound.Play();
                                            }
                                            else
                                            {
                                                if (PlayerPrefs.GetInt("Answer106Correct") == 0)
                                                {
                                                    PlayerPrefs.SetInt("Answer106", 1);
                                                    PlayerPrefs.SetInt("Answer106Correct", 1);
                                                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                    hintPanel.SetActive(false);
                                                    correctSound.Play();
                                                }
                                                else
                                                {
                                                    if (PlayerPrefs.GetInt("Answer107Correct") == 0)
                                                    {
                                                        PlayerPrefs.SetInt("Answer107", 1);
                                                        PlayerPrefs.SetInt("Answer107Correct", 1);
                                                        PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                        hintPanel.SetActive(false);
                                                        correctSound.Play();
                                                    }
                                                    else
                                                    {
                                                        if (PlayerPrefs.GetInt("Answer108Correct") == 0)
                                                        {
                                                            PlayerPrefs.SetInt("Answer108", 1);
                                                            PlayerPrefs.SetInt("Answer108Correct", 1);
                                                            PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                            hintPanel.SetActive(false);
                                                            correctSound.Play();
                                                        }
                                                        else
                                                        {
                                                            if (PlayerPrefs.GetInt("Answer109Correct") == 0)
                                                            {
                                                                PlayerPrefs.SetInt("Answer109", 1);
                                                                PlayerPrefs.SetInt("Answer109Correct", 1);
                                                                PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                                hintPanel.SetActive(false);
                                                                correctSound.Play();
                                                            }
                                                            else
                                                            {
                                                                if (PlayerPrefs.GetInt("Answer110Correct") == 0)
                                                                {
                                                                    PlayerPrefs.SetInt("Answer110", 1);
                                                                    PlayerPrefs.SetInt("Answer110Correct", 1);
                                                                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                                    hintPanel.SetActive(false);
                                                                    correctSound.Play();
                                                                }
                                                                else
                                                                {
                                                                    if (PlayerPrefs.GetInt("Answer111Correct") == 0)
                                                                    {
                                                                        PlayerPrefs.SetInt("Answer111", 1);
                                                                        PlayerPrefs.SetInt("Answer111Correct", 1);
                                                                        PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                                        hintPanel.SetActive(false);
                                                                        correctSound.Play();
                                                                    }
                                                                    else
                                                                    {
                                                                        if (PlayerPrefs.GetInt("Answer112Correct") == 0)
                                                                        {
                                                                            PlayerPrefs.SetInt("Answer112", 1);
                                                                            PlayerPrefs.SetInt("Answer112Correct", 1);
                                                                            PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                                            hintPanel.SetActive(false);
                                                                            correctSound.Play();
                                                                        }
                                                                        else
                                                                        {
                                                                            if (PlayerPrefs.GetInt("Answer113Correct") == 0)
                                                                            {
                                                                                PlayerPrefs.SetInt("Answer113", 1);
                                                                                PlayerPrefs.SetInt("Answer113Correct", 1);
                                                                                PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                                                hintPanel.SetActive(false);
                                                                                correctSound.Play();
                                                                            }
                                                                            else
                                                                            {
                                                                                if (PlayerPrefs.GetInt("Answer114Correct") == 0)
                                                                                {
                                                                                    PlayerPrefs.SetInt("Answer114", 1);
                                                                                    PlayerPrefs.SetInt("Answer114Correct", 1);
                                                                                    PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                                                    hintPanel.SetActive(false);
                                                                                    correctSound.Play();
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (PlayerPrefs.GetInt("Answer115Correct") == 0)
                                                                                    {
                                                                                        PlayerPrefs.SetInt("Answer115", 1);
                                                                                        PlayerPrefs.SetInt("Answer115Correct", 1);
                                                                                        PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
                                                                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                                                        hintPanel.SetActive(false);
                                                                                        correctSound.Play();
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (PlayerPrefs.GetInt("Answer116Correct") == 0)
                                                                                        {
                                                                                            PlayerPrefs.SetInt("Answer116", 1);
                                                                                            PlayerPrefs.SetInt("Answer116Correct", 1);
                                                                                            PlayerPrefs.SetInt("Round15Complete", PlayerPrefs.GetInt("Round15Complete") + 1);
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

   /* public void successPanelActivate()
    {
        successPanel.SetActive(true);
        successAnim.SetTrigger("Start");
        ansPanel.SetActive(false);
        //nextButton.SetActive(false);
        tilePanel.SetActive(false);
    }*/
}
