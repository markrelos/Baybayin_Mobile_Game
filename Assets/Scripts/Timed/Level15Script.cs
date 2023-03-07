﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level15Script : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3, Tile4, Tile5, Tile6;
    [SerializeField]
    Image[] Ans;
    //[HideInInspector]
    //public bool qualified;
    [SerializeField]
    Animator congratsAnim, leaderAnim, perfectAnim, otherGameAnim, quitAnim, otherGameAnimLeader;
    [SerializeField]
    GameObject answerPanel, tilePanel, congratsPanel, shuffleButtonObj, leaderPanel, perfectPanel, otherGamePanel, otherGamePanelLeader, quitPanel;
    [HideInInspector]
    public int answersCompleted;
    [SerializeField]
    bool[] answerComplete;
    bool isPerfect = true;
    [SerializeField]
    int startTime;
    [SerializeField]
    Image timerSlider;
    [SerializeField]
    public TextMeshProUGUI timerText, scoreText, otherScoreText, inputName, completeScore, completeInputName;
    int minutes;
    float seconds;
    float timer;
    int scoreTotal;
    bool addScore;
    string scoreName, completeScoreName;
    //bool noNext = true;
    [SerializeField]
    AudioSource correctSound, wrongSound, tickingSound, correctLong;
    bool playTick = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Ans.Length; i++)
        {
            Ans[i].canvasRenderer.SetAlpha(0.0f);
        }
        leaderPanel.SetActive(false);
        perfectPanel.SetActive(false);
        quitPanel.SetActive(false);
        congratsPanel.SetActive(false);
        otherGamePanel.SetActive(false);
        otherGamePanelLeader.SetActive(false);
        //qualified = false;
        timer = startTime;
        timerText.text = minutes.ToString() + ":" + seconds.ToString();
        addScore = true;
        scoreTotal = PlayerPrefs.GetInt("ScoreToPersist");
        answersCompleted = 0;
        //bool[] answerComplete = new bool[] {true, true, true, true, true};
        for (int i = 0; i < answerComplete.Length; i++)
        {
            answerComplete[i] = true;
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
                if (answerComplete[0])
                {
                    answersCompleted += 1;
                    answerComplete[0] = false;
                    scoreTotal += 100;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
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
                if (answerComplete[1])
                {
                    answersCompleted += 1;
                    answerComplete[1] = false;
                    scoreTotal += 100;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
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
                if (answerComplete[2])
                {
                    answersCompleted += 1;
                    answerComplete[2] = false;
                    scoreTotal += 100;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                if (answerComplete[3])
                {
                    answersCompleted += 1;
                    answerComplete[3] = false;
                    scoreTotal += 100;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[8].CrossFadeAlpha(1, 2, false);
                Ans[9].CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                if (answerComplete[4])
                {
                    answersCompleted += 1;
                    answerComplete[4] = false;
                    scoreTotal += 100;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile4 && parent.transform.GetChild(1) == Tile2)
            {
                Ans[10].CrossFadeAlpha(1, 2, false);
                Ans[11].CrossFadeAlpha(1, 2, false);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                if (answerComplete[5])
                {
                    answersCompleted += 1;
                    answerComplete[5] = false;
                    scoreTotal += 100;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
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
                if (answerComplete[6])
                {
                    answersCompleted += 1;
                    answerComplete[6] = false;
                    scoreTotal += 100;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile5 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[14].CrossFadeAlpha(1, 2, false);
                Ans[15].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                if (answerComplete[7])
                {
                    answersCompleted += 1;
                    answerComplete[7] = false;
                    scoreTotal += 100;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile2.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
            }

        }
        else if (parent.childCount == 3)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile5 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[16].CrossFadeAlpha(1, 2, false);
                Ans[17].CrossFadeAlpha(1, 2, false);
                Ans[18].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                if (answerComplete[8])
                {
                    answersCompleted += 1;
                    answerComplete[8] = false;
                    scoreTotal += 200;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile4)
            {
                Ans[19].CrossFadeAlpha(1, 2, false);
                Ans[20].CrossFadeAlpha(1, 2, false);
                Ans[21].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                if (answerComplete[9])
                {
                    answersCompleted += 1;
                    answerComplete[9] = false;
                    scoreTotal += 200;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile4 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile6)
            {
                Ans[22].CrossFadeAlpha(1, 2, false);
                Ans[23].CrossFadeAlpha(1, 2, false);
                Ans[24].CrossFadeAlpha(1, 2, false);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                if (answerComplete[10])
                {
                    answersCompleted += 1;
                    answerComplete[10] = false;
                    scoreTotal += 200;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile5 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile6)
            {
                Ans[25].CrossFadeAlpha(1, 2, false);
                Ans[26].CrossFadeAlpha(1, 2, false);
                Ans[27].CrossFadeAlpha(1, 2, false);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                if (answerComplete[11])
                {
                    answersCompleted += 1;
                    answerComplete[11] = false;
                    scoreTotal += 200;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile4.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 4)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile4 && parent.transform.GetChild(2) == Tile5 && parent.transform.GetChild(3) == Tile6)
            {
                Ans[28].CrossFadeAlpha(1, 2, false);
                Ans[29].CrossFadeAlpha(1, 2, false);
                Ans[30].CrossFadeAlpha(1, 2, false);
                Ans[31].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                if (answerComplete[12])
                {
                    answersCompleted += 1;
                    answerComplete[12] = false;
                    scoreTotal += 400;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile4 && parent.transform.GetChild(3) == Tile6)
            {
                Ans[32].CrossFadeAlpha(1, 2, false);
                Ans[33].CrossFadeAlpha(1, 2, false);
                Ans[34].CrossFadeAlpha(1, 2, false);
                Ans[35].CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                if (answerComplete[13])
                {
                    answersCompleted += 1;
                    answerComplete[13] = false;
                    scoreTotal += 400;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile3 && parent.transform.GetChild(1) == Tile4 && parent.transform.GetChild(2) == Tile5 && parent.transform.GetChild(3) == Tile6)
            {
                Ans[36].CrossFadeAlpha(1, 2, false);
                Ans[37].CrossFadeAlpha(1, 2, false);
                Ans[38].CrossFadeAlpha(1, 2, false);
                Ans[39].CrossFadeAlpha(1, 2, false);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                if (answerComplete[14])
                {
                    answersCompleted += 1;
                    answerComplete[14] = false;
                    scoreTotal += 400;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile6.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 5)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile4 && parent.transform.GetChild(3) == Tile5 && parent.transform.GetChild(4) == Tile6)
            {
                Ans[40].CrossFadeAlpha(1, 2, false);
                Ans[41].CrossFadeAlpha(1, 2, false);
                Ans[42].CrossFadeAlpha(1, 2, false);
                Ans[43].CrossFadeAlpha(1, 2, false);
                Ans[44].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                /*cancelButton.interactable = false;
                nextButton.interactable = true;
                cancelImage.canvasRenderer.SetAlpha(0.0f);
                nextImage.CrossFadeAlpha(1, 1, false);
                qualified = true;*/
                if (answerComplete[15])
                {
                    answersCompleted += 1;
                    answerComplete[15] = false;
                    scoreTotal += 600;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile4 && parent.transform.GetChild(3) == Tile5 && parent.transform.GetChild(4) == Tile6)
            {
                Ans[45].CrossFadeAlpha(1, 2, false);
                Ans[46].CrossFadeAlpha(1, 2, false);
                Ans[47].CrossFadeAlpha(1, 2, false);
                Ans[48].CrossFadeAlpha(1, 2, false);
                Ans[49].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                if (answerComplete[16])
                {
                    answersCompleted += 1;
                    answerComplete[16] = false;
                    scoreTotal += 600;
                    Debug.Log(answersCompleted);
                    correctSound.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 6)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3 && parent.transform.GetChild(3) == Tile4 && parent.transform.GetChild(4) == Tile5 && parent.transform.GetChild(5) == Tile6)
            {
                Ans[50].CrossFadeAlpha(1, 2, false);
                Ans[51].CrossFadeAlpha(1, 2, false);
                Ans[52].CrossFadeAlpha(1, 2, false);
                Ans[53].CrossFadeAlpha(1, 2, false);
                Ans[54].CrossFadeAlpha(1, 2, false);
                Ans[55].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                /*cancelButton.interactable = false;
                nextButton.interactable = true;
                cancelImage.canvasRenderer.SetAlpha(0.0f);
                nextImage.CrossFadeAlpha(1, 1, false);
                qualified = true;*/
                if (answerComplete[17])
                {
                    answersCompleted += 1;
                    answerComplete[17] = false;
                    scoreTotal += 800;
                    Debug.Log(answersCompleted);
                    correctLong.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile6.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else
        {
            Tile4.transform.SetParent(parentToReturnTo);
            Tile6.transform.SetParent(parentToReturnTo);
            Tile2.transform.SetParent(parentToReturnTo);
            Tile1.transform.SetParent(parentToReturnTo);
            Tile3.transform.SetParent(parentToReturnTo);
            Tile5.transform.SetParent(parentToReturnTo);
            wrongSound.Play();
            Debug.Log("Return");
        }
    }
    void Update()
    {
        scoreText.text = scoreTotal.ToString("0");
        if (answersCompleted != 18 && timer > 0 /*&& noNext*/)
        {
            timer -= Time.deltaTime;
            timerSlider.fillAmount = (timer / startTime);
            //FormatText();
            minutes = (int)(timer / 60) % 60;
            seconds = (int)(timer % 60);
            string secondsString = seconds.ToString("00");
            string minutesString = minutes.ToString("0");
            timerText.text = minutesString + ":" + secondsString;
            Debug.Log("Timer working");
        }
        else if (answersCompleted == 18 && timer > 0 /*&& noNext*/)
        {
            for (int i = 0; i < Ans.Length; i++)
            {
                Ans[i].canvasRenderer.SetAlpha(1f);
            }
            if (isPerfect)
            {
                scoreTotal += 1000;
                isPerfect = false;
            }
            congratsPanel.SetActive(true);
            congratsAnim.SetTrigger("Start");
            //leaderPanel.SetActive(true);
            //leaderAnim.SetTrigger("Start");
            otherGamePanel.SetActive(true);
            otherGameAnim.SetTrigger("Start");
            answerPanel.SetActive(false);
            tilePanel.SetActive(false);
            shuffleButtonObj.SetActive(false);
            //nextButtons.SetActive(false);
            perfectPanel.SetActive(true);
            perfectAnim.SetTrigger("Start");
            otherGamePanel.SetActive(true);
            otherGameAnim.SetTrigger("Start");
            tickingSound.Stop();
            if (addScore)
            {
                scoreTotal += (int)timer;
                PlayerPrefs.SetInt("ScoreToPersist", scoreTotal);
                otherScoreText.text = scoreTotal.ToString("0");
                completeScore.text = scoreTotal.ToString("0");
                addScore = false;
            }
            //StartCoroutine(timeStop());
        }
        else if (answersCompleted != 18 && timer <= 0 /*&& noNext*/)
        {
            /*if (qualified)
            {
                congratsPanel.SetActive(true);
                congratsAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                nextButtons.SetActive(false);
                Debug.Log("Congrats");
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    otherScoreText.text = scoreTotal.ToString("0");
                    PlayerPrefs.SetInt("ScoreToPersist", scoreTotal);
                    addScore = false;
                }
            }
            else
            {*/
                //gameOverPanel.SetActive(true);
                //gameOverAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                otherGamePanelLeader.SetActive(true);
                otherGameAnimLeader.SetTrigger("Start");
                tickingSound.Stop();
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    otherScoreText.text = scoreTotal.ToString("0");
                    completeScore.text = scoreTotal.ToString("0");
                    addScore = false;
                }

                for (int i = 0; i < Ans.Length; i++)
                {
                    Ans[i].canvasRenderer.SetAlpha(0.5f);
                }
                Debug.Log("Failed");
            //}
        }
        /*else if (answersCompleted != 18 && timer > 0 && noNext == false)
        {
            if (qualified)
            {
                congratsPanel.SetActive(true);
                congratsAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                nextButtons.SetActive(false);
                Debug.Log("Congrats");
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    otherScoreText.text = scoreTotal.ToString("0");
                    PlayerPrefs.SetInt("ScoreToPersist", scoreTotal);
                    addScore = false;
                }
            }
            else
            {
                gameOverPanel.SetActive(true);
                gameOverAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    otherScoreText.text = scoreTotal.ToString("0");
                    addScore = false;
                }

                for (int i = 0; i < Ans.Length; i++)
                {
                    Ans[i].canvasRenderer.SetAlpha(0.5f);
                }
                Debug.Log("Failed");
            }
        }
        else
        {
            if (qualified)
            {
                congratsPanel.SetActive(true);
                congratsAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                nextButtons.SetActive(false);
                Debug.Log("Congrats");
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    PlayerPrefs.SetInt("ScoreToPersist", scoreTotal);
                    otherScoreText.text = scoreTotal.ToString("0");
                    addScore = false;
                }
            }
            else
            {
                gameOverPanel.SetActive(true);
                gameOverAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    otherScoreText.text = scoreTotal.ToString("0");
                    addScore = false;
                }

                for (int i = 0; i < Ans.Length; i++)
                {
                    Ans[i].canvasRenderer.SetAlpha(0.5f);
                }
                Debug.Log("Failed");
            }
        }*/
        if (timer < 11)
        {
            if (playTick == false)
            {
                tickingSound.Play();
                playTick = true;
            }
        }
        else if (timer <= 0)
        {
            tickingSound.Stop();
        }
    }

    public void AddToLeaderboard()
    {
        scoreName = inputName.text;
        Leaderboards.Record(scoreName, scoreTotal);
        PlayerPrefs.DeleteKey("ScoreToPersist");
        Debug.Log("Score Added to Leaderboards");
    }
    public void AddToLeaderboardComplete()
    {
        completeScoreName = completeInputName.text;
        Leaderboards.Record(completeScoreName, scoreTotal);
        PlayerPrefs.DeleteKey("ScoreToPersist");
        Debug.Log("Score Added to Leaderboards");
    }

    /*public void moveNext()
    {
        noNext = false;
    }*/

    public void quitButton()
    {
        quitPanel.SetActive(true);
        quitAnim.SetTrigger("Start");
    }
    public void closeQuitPanel()
    {
        quitPanel.SetActive(false);
    }
}