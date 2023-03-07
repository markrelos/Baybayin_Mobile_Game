using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level13Script : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3, Tile4, Tile5;
    [SerializeField]
    Image[] Ans;
    [HideInInspector]
    public bool qualified;
    [SerializeField]
    Animator congratsAnim, leaderAnim, perfectAnim, quitAnim, otherAnim;
    [SerializeField]
    GameObject answerPanel, tilePanel, congratsPanel, shuffleButtonObj, leaderPanel, nextButtons, perfectPanel, quitPanel, otherPanel;
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
    public TextMeshProUGUI timerText, scoreText, otherScoreText, inputName;
    int minutes;
    float seconds;
    float timer;
    int scoreTotal;
    bool addScore;
    string scoreName;
    bool noNext = true;
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
        nextButtons.SetActive(false);
        leaderPanel.SetActive(false);
        perfectPanel.SetActive(false);
        quitPanel.SetActive(false);
        congratsPanel.SetActive(false);
        otherPanel.SetActive(false);
        qualified = false;
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
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile3)
            {
                Ans[2].CrossFadeAlpha(1, 2, false);
                Ans[3].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
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
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[4].CrossFadeAlpha(1, 2, false);
                Ans[5].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
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
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1)
            {
                Ans[6].CrossFadeAlpha(1, 2, false);
                Ans[7].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
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
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile3)
            {
                Ans[8].CrossFadeAlpha(1, 2, false);
                Ans[9].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
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
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile4)
            {
                Ans[10].CrossFadeAlpha(1, 2, false);
                Ans[11].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
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
            else
            {
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
            }

        }
        else if (parent.childCount == 3)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile5)
            {
                Ans[12].CrossFadeAlpha(1, 2, false);
                Ans[13].CrossFadeAlpha(1, 2, false);
                Ans[14].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                if (answerComplete[6])
                {
                    answersCompleted += 1;
                    answerComplete[6] = false;
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
            else if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile4 && parent.transform.GetChild(2) == Tile5)
            {
                Ans[15].CrossFadeAlpha(1, 2, false);
                Ans[16].CrossFadeAlpha(1, 2, false);
                Ans[17].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                if (answerComplete[7])
                {
                    answersCompleted += 1;
                    answerComplete[7] = false;
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
                wrongSound.Play();
                Debug.Log("Return");
            }
        }
        else if (parent.childCount == 4)
        {
            if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile3 && parent.transform.GetChild(2) == Tile1 && parent.transform.GetChild(3) == Tile5)
            {
                Ans[18].CrossFadeAlpha(1, 2, false);
                Ans[19].CrossFadeAlpha(1, 2, false);
                Ans[20].CrossFadeAlpha(1, 2, false);
                Ans[21].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                if (answerComplete[8])
                {
                    answersCompleted += 1;
                    answerComplete[8] = false;
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
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1 && parent.transform.GetChild(2) == Tile4 && parent.transform.GetChild(3) == Tile5)
            {
                Ans[22].CrossFadeAlpha(1, 2, false);
                Ans[23].CrossFadeAlpha(1, 2, false);
                Ans[24].CrossFadeAlpha(1, 2, false);
                Ans[25].CrossFadeAlpha(1, 2, false);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile4.transform.SetParent(parentToReturnTo);
                Tile5.transform.SetParent(parentToReturnTo);
                if (answerComplete[9])
                {
                    answersCompleted += 1;
                    answerComplete[9] = false;
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
                nextButtons.SetActive(true);
                qualified = true;
                if (answerComplete[10])
                {
                    answersCompleted += 1;
                    answerComplete[10] = false;
                    scoreTotal += 600;
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
                Tile3.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }
        }

        else
        {
            Tile4.transform.SetParent(parentToReturnTo);
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
        if (answersCompleted != 11 && timer > 0 && noNext)
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
        else if (answersCompleted == 11 && timer > 0 && noNext)
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
            answerPanel.SetActive(false);
            tilePanel.SetActive(false);
            shuffleButtonObj.SetActive(false);
            nextButtons.SetActive(false);
            perfectPanel.SetActive(true);
            perfectAnim.SetTrigger("Start");
            tickingSound.Stop();
            if (addScore)
            {
                scoreTotal += (int)timer;
                PlayerPrefs.SetInt("ScoreToPersist", scoreTotal);
                addScore = false;
            }
            //StartCoroutine(timeStop());
        }
        else if (answersCompleted != 11 && timer <= 0 && noNext)
        {
            if (qualified)
            {
                congratsPanel.SetActive(true);
                congratsAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                nextButtons.SetActive(false);
                Debug.Log("Congrats");
                tickingSound.Stop();
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    PlayerPrefs.SetInt("ScoreToPersist", scoreTotal);
                    addScore = false;
                }
            }
            else
            {
                //gameOverPanel.SetActive(true);
                //gameOverAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                otherPanel.SetActive(true);
                otherAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                tickingSound.Stop();
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
        else if (answersCompleted != 11 && timer > 0 && noNext == false)
        {
            if (qualified)
            {
                congratsPanel.SetActive(true);
                congratsAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                nextButtons.SetActive(false);
                Debug.Log("Congrats");
                tickingSound.Stop();
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    PlayerPrefs.SetInt("ScoreToPersist", scoreTotal);
                    addScore = false;
                }
            }
            else
            {
                //gameOverPanel.SetActive(true);
                //gameOverAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                otherPanel.SetActive(true);
                otherAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                tickingSound.Stop();
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
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                nextButtons.SetActive(false);
                Debug.Log("Congrats");
                tickingSound.Stop();
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    PlayerPrefs.SetInt("ScoreToPersist", scoreTotal);
                    addScore = false;
                }
            }
            else
            {
                //gameOverPanel.SetActive(true);
                //gameOverAnim.SetTrigger("Start");
                leaderPanel.SetActive(true);
                leaderAnim.SetTrigger("Start");
                otherPanel.SetActive(true);
                otherAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                tickingSound.Stop();
                if (addScore)
                {
                    scoreTotal += (int)timer;
                    addScore = false;
                }

                for (int i = 0; i < Ans.Length; i++)
                {
                    Ans[i].canvasRenderer.SetAlpha(0.5f);
                }
                Debug.Log("Failed");
            }
        }
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

    public void moveNext()
    {
        noNext = false;
    }
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
