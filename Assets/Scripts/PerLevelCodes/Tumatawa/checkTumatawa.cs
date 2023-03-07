using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class checkTumatawa : MonoBehaviour
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
        int answer54 = PlayerPrefs.GetInt("Answer54", 0);
        int answer55 = PlayerPrefs.GetInt("Answer55", 0);
        int answer56 = PlayerPrefs.GetInt("Answer56", 0);
        int answer57 = PlayerPrefs.GetInt("Answer57", 0);
        int answer58 = PlayerPrefs.GetInt("Answer58", 0);
        int answer59 = PlayerPrefs.GetInt("Answer59", 0);
        int answer60 = PlayerPrefs.GetInt("Answer60", 0);
        int answer61 = PlayerPrefs.GetInt("Answer61", 0);
        int answer62 = PlayerPrefs.GetInt("Answer62", 0);
        int answer63 = PlayerPrefs.GetInt("Answer63", 0);
        int answer64 = PlayerPrefs.GetInt("Answer64", 0);
        int unlockLevel = PlayerPrefs.GetInt("levelUnlocked");

        if (unlockLevel > 11)
        {
            nextButton.SetActive(true);
        }

        if (answer54 != 1)
        {
            Ans[0].canvasRenderer.SetAlpha(0.0f);
            Ans[1].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer55 != 1)
        {
            Ans[2].canvasRenderer.SetAlpha(0.0f);
            Ans[3].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer56 != 1)
        {
            Ans[4].canvasRenderer.SetAlpha(0.0f);
            Ans[5].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer57 != 1)
        {
            Ans[6].canvasRenderer.SetAlpha(0.0f);
            Ans[7].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer58 != 1)
        {
            Ans[8].canvasRenderer.SetAlpha(0.0f);
            Ans[9].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer59 != 1)
        {
            Ans[10].canvasRenderer.SetAlpha(0.0f);
            Ans[11].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer60 != 1)
        {
            Ans[12].canvasRenderer.SetAlpha(0.0f);
            Ans[13].canvasRenderer.SetAlpha(0.0f);
            Ans[14].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer61 != 1)
        {
            Ans[15].canvasRenderer.SetAlpha(0.0f);
            Ans[16].canvasRenderer.SetAlpha(0.0f);
            Ans[17].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer62 != 1)
        {
            Ans[18].canvasRenderer.SetAlpha(0.0f);
            Ans[19].canvasRenderer.SetAlpha(0.0f);
            Ans[20].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer63 != 1)
        {
            Ans[21].canvasRenderer.SetAlpha(0.0f);
            Ans[22].canvasRenderer.SetAlpha(0.0f);
            Ans[23].canvasRenderer.SetAlpha(0.0f);
        }
        if (answer64 != 1)
        {
            Ans[24].canvasRenderer.SetAlpha(0.0f);
            Ans[25].canvasRenderer.SetAlpha(0.0f);
            Ans[26].canvasRenderer.SetAlpha(0.0f);
            Ans[27].canvasRenderer.SetAlpha(0.0f);
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
                PlayerPrefs.SetInt("Answer54", 1);
                if (PlayerPrefs.GetInt("Answer54Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer54Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
                PlayerPrefs.SetInt("Answer55", 1);
                if (PlayerPrefs.GetInt("Answer55Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer55Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
                PlayerPrefs.SetInt("Answer56", 1);
                if (PlayerPrefs.GetInt("Answer56Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer56Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
                PlayerPrefs.SetInt("Answer57", 1);
                if (PlayerPrefs.GetInt("Answer57Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer57Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
                PlayerPrefs.SetInt("Answer58", 1);
                if (PlayerPrefs.GetInt("Answer58Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer58Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
                PlayerPrefs.SetInt("Answer59", 1);
                if (PlayerPrefs.GetInt("Answer59Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer59Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[12].CrossFadeAlpha(1, 2, false);
                Ans[13].CrossFadeAlpha(1, 2, false);
                Ans[14].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer60", 1);
                if (PlayerPrefs.GetInt("Answer60Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer60Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
                Ans[15].CrossFadeAlpha(1, 2, false);
                Ans[16].CrossFadeAlpha(1, 2, false);
                Ans[17].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer61", 1);
                if (PlayerPrefs.GetInt("Answer61Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer61Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
                Ans[18].CrossFadeAlpha(1, 2, false);
                Ans[19].CrossFadeAlpha(1, 2, false);
                Ans[20].CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer62", 1);
                if (PlayerPrefs.GetInt("Answer62Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer62Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[21].CrossFadeAlpha(1, 2, false);
                Ans[22].CrossFadeAlpha(1, 2, false);
                Ans[23].CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                PlayerPrefs.SetInt("Answer63", 1);
                if (PlayerPrefs.GetInt("Answer63Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer63Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
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
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile4)
            {
                Ans[24].CrossFadeAlpha(1, 2, false);
                Ans[25].CrossFadeAlpha(1, 2, false);
                Ans[26].CrossFadeAlpha(1, 2, false);
                Ans[27].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                nextButton.SetActive(true);
                PlayerPrefs.SetInt("Answer64", 1);
                if (PlayerPrefs.GetInt("Answer64Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 1);
                    PlayerPrefs.SetInt("Answer64Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                    correctSound.Play();
                    StartCoroutine(coinsTwoPanel());
                }
                else
                {
                    wrongSound.Play();
                }
                if (PlayerPrefs.GetInt("levelUnlocked", 0) < 12)
                {
                    PlayerPrefs.SetInt("levelUnlocked", 12);
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
        if (PlayerPrefs.GetInt("Round11Complete") == 11)
        {
            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
            PlayerPrefs.SetInt("Round11Complete", 12);
            StartCoroutine(coinsFivePanel());
        }
        if (PlayerPrefs.GetInt("Round11Complete") == 12)
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
        if (PlayerPrefs.GetInt("Answer54Correct") == 1)
        {
            Ans[0].CrossFadeAlpha(1, 2, false);
            Ans[1].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer55Correct") == 1)
        {
            Ans[2].CrossFadeAlpha(1, 2, false);
            Ans[3].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer56Correct") == 1)
        {
            Ans[4].CrossFadeAlpha(1, 2, false);
            Ans[5].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer57Correct") == 1)
        {
            Ans[6].CrossFadeAlpha(1, 2, false);
            Ans[7].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer58Correct") == 1)
        {
            Ans[8].CrossFadeAlpha(1, 2, false);
            Ans[9].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer59Correct") == 1)
        {
            Ans[10].CrossFadeAlpha(1, 2, false);
            Ans[11].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer60Correct") == 1)
        {
            Ans[12].CrossFadeAlpha(1, 2, false);
            Ans[13].CrossFadeAlpha(1, 2, false);
            Ans[14].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer61Correct") == 1)
        {
            Ans[15].CrossFadeAlpha(1, 2, false);
            Ans[16].CrossFadeAlpha(1, 2, false);
            Ans[17].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer62Correct") == 1)
        {
            Ans[18].CrossFadeAlpha(1, 2, false);
            Ans[19].CrossFadeAlpha(1, 2, false);
            Ans[20].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer63Correct") == 1)
        {
            Ans[21].CrossFadeAlpha(1, 2, false);
            Ans[22].CrossFadeAlpha(1, 2, false);
            Ans[23].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("Answer64Correct") == 1)
        {
            Ans[24].CrossFadeAlpha(1, 2, false);
            Ans[25].CrossFadeAlpha(1, 2, false);
            Ans[26].CrossFadeAlpha(1, 2, false);
            Ans[27].CrossFadeAlpha(1, 2, false);
        }
        if (PlayerPrefs.GetInt("levelUnlocked") == 12)
        {
            if (PlayerPrefs.GetInt("levelElevenUnlocked", 0) == 0)
            {
                StartCoroutine(newLvlAnimation());
                PlayerPrefs.SetInt("levelElevenUnlocked", 1);
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

    public void HintLevelEleven()
    {
        if (PlayerPrefs.GetInt("coinsTotal") >= 5)
        {
            if (PlayerPrefs.GetInt("Answer54Correct") == 0)
            {
                PlayerPrefs.SetInt("Answer54", 1);
                PlayerPrefs.SetInt("Answer54Correct", 1);
                PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                hintPanel.SetActive(false);
                correctSound.Play();
            }
            else
            {
                if (PlayerPrefs.GetInt("Answer55Correct") == 0)
                {
                    PlayerPrefs.SetInt("Answer55", 1);
                    PlayerPrefs.SetInt("Answer55Correct", 1);
                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                    hintPanel.SetActive(false);
                    correctSound.Play();
                }
                else
                {
                    if (PlayerPrefs.GetInt("Answer56Correct") == 0)
                    {
                        PlayerPrefs.SetInt("Answer56", 1);
                        PlayerPrefs.SetInt("Answer56Correct", 1);
                        PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                        hintPanel.SetActive(false);
                        correctSound.Play();
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("Answer57Correct") == 0)
                        {
                            PlayerPrefs.SetInt("Answer57", 1);
                            PlayerPrefs.SetInt("Answer57Correct", 1);
                            PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                            hintPanel.SetActive(false);
                            correctSound.Play();
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("Answer58Correct") == 0)
                            {
                                PlayerPrefs.SetInt("Answer58", 1);
                                PlayerPrefs.SetInt("Answer58Correct", 1);
                                PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                hintPanel.SetActive(false);
                                correctSound.Play();
                            }
                            else
                            {
                                if (PlayerPrefs.GetInt("Answer59Correct") == 0)
                                {
                                    PlayerPrefs.SetInt("Answer59", 1);
                                    PlayerPrefs.SetInt("Answer59Correct", 1);
                                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                    hintPanel.SetActive(false);
                                    correctSound.Play();
                                }
                                else
                                {

                                    if (PlayerPrefs.GetInt("Answer60Correct") == 0)
                                    {
                                        PlayerPrefs.SetInt("Answer60", 1);
                                        PlayerPrefs.SetInt("Answer60Correct", 1);
                                        PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                        hintPanel.SetActive(false);
                                        correctSound.Play();
                                    }
                                    else
                                    {

                                        if (PlayerPrefs.GetInt("Answer61Correct") == 0)
                                        {
                                            PlayerPrefs.SetInt("Answer61", 1);
                                            PlayerPrefs.SetInt("Answer61Correct", 1);
                                            PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                                            PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                            hintPanel.SetActive(false);
                                            correctSound.Play();
                                        }
                                        else
                                        {
                                            if (PlayerPrefs.GetInt("Answer62Correct") == 0)
                                            {
                                                PlayerPrefs.SetInt("Answer62", 1);
                                                PlayerPrefs.SetInt("Answer62Correct", 1);
                                                PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                                                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                hintPanel.SetActive(false);
                                                correctSound.Play();
                                            }
                                            else
                                            {
                                                if (PlayerPrefs.GetInt("Answer63Correct") == 0)
                                                {
                                                    PlayerPrefs.SetInt("Answer63", 1);
                                                    PlayerPrefs.SetInt("Answer63Correct", 1);
                                                    PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                                                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                    hintPanel.SetActive(false);
                                                    correctSound.Play();
                                                }
                                                else
                                                {
                                                    if (PlayerPrefs.GetInt("Answer64Correct") == 0)
                                                    {
                                                        PlayerPrefs.SetInt("Answer64", 1);
                                                        PlayerPrefs.SetInt("Answer64Correct", 1);
                                                        PlayerPrefs.SetInt("Round11Complete", PlayerPrefs.GetInt("Round11Complete") + 1);
                                                        PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 5);
                                                        if (PlayerPrefs.GetInt("levelUnlocked", 0) < 12)
                                                        {
                                                            PlayerPrefs.SetInt("levelUnlocked", 12);
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
