using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level1Script : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2;
    [SerializeField]
    Image[] Ans;
    [HideInInspector]
    public bool qualified;
    [SerializeField]
    Animator congratsAnim, leaderAnim, perfectAnim, quitAnim, otherAnim;
    [SerializeField]
    GameObject answerPanel, tilePanel, congratsPanel, shuffleButtonObj, leaderPanel, nextButtons, perfectPanel, quitPanel, otherPanel;
    [HideInInspector]
    public int answersCompleted = 0;
    //public countdownTimer countTimer;
    bool answer1Complete = true;
    bool answer2Complete = true;
    bool isPerfect = true;
    bool noNext = true;

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
        PlayerPrefs.SetInt("ScoreToPersist", 0);
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
                nextButtons.SetActive(true);
                qualified = true;
                if (answer1Complete)
                {
                    answersCompleted += 1;
                    answer1Complete = false;
                    scoreTotal += 100;
                    correctLong.Play();
                }
                else
                {
                    wrongSound.Play();
                }
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1)
            {
                Ans[2].CrossFadeAlpha(1, 2, false);
                Ans[3].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                nextButtons.SetActive(true);
                qualified = true;
                if (answer2Complete)
                {
                    answersCompleted += 1;
                    answer2Complete = false;
                    scoreTotal += 100;
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
                Tile1.transform.SetParent(parentToReturnTo);
                wrongSound.Play();
                Debug.Log("Return");
            }

        }

        else
        {
            Tile1.transform.SetParent(parentToReturnTo);
            Tile2.transform.SetParent(parentToReturnTo);
            wrongSound.Play();
            Debug.Log("Return");
        }
    }
    void Update()
    {
        scoreText.text = scoreTotal.ToString("0");
        if (answersCompleted != 2 && timer>0 && noNext)
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
        else if (answersCompleted == 2 && timer>0 && noNext)
        {
            for (int i = 0; i < Ans.Length; i++)
            {
                Ans[i].canvasRenderer.SetAlpha(1f);
            }
            if(isPerfect)
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
        else if(answersCompleted !=2 && timer <= 0 && noNext)
        {
            if (qualified)
            {
                congratsPanel.SetActive(true);
                congratsAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                nextButtons.SetActive(false);
                tickingSound.Stop();
                Debug.Log("Congrats");
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
        else if (answersCompleted != 2 && timer > 0 && noNext == false)
        {
            if (qualified)
            {
                congratsPanel.SetActive(true);
                congratsAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                shuffleButtonObj.SetActive(false);
                nextButtons.SetActive(false);
                tickingSound.Stop();
                Debug.Log("Congrats");
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
                tickingSound.Stop();
                Debug.Log("Congrats");
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
        else if(timer <= 0)
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
