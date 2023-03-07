using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class checkBaka : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2;
    [SerializeField]
    Image[] Ans;
    [SerializeField]
    Image nextImage, cancelImage;
    public Button nextButton, cancelButton;
    [HideInInspector]
    public bool qualified;
    [SerializeField]
    Animator congratsAnim, gameOverAnim;
    [SerializeField]
    GameObject answerPanel, tilePanel, congratsPanel, gameOverPanel;
    [HideInInspector]
    public int answersCompleted=0;
    //public countdownTimer countTimer;
    bool answer1Complete = true;
    bool answer2Complete = true;

    [SerializeField]
    float startTime = 30f;
    [SerializeField]
    Image timerSlider;
    [SerializeField]
    public TextMeshProUGUI timerText;
    int minutes;
    float seconds;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Ans.Length; i++)
        {
                Ans[i].canvasRenderer.SetAlpha(0.0f);
        }      
        nextButton.interactable = false;
        gameOverPanel.SetActive(false);
        nextImage.canvasRenderer.SetAlpha(0.0f);
        qualified = false;

        timerText.text = minutes.ToString() + ":" + seconds.ToString();

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
                cancelButton.interactable = false;
                nextButton.interactable = true;
                cancelImage.canvasRenderer.SetAlpha(0.0f);
                nextImage.CrossFadeAlpha(1, 1, false);
                qualified = true;
                if(answer1Complete)
                {
                    answersCompleted+=1;
                    answer1Complete = false;
                }                
                Debug.Log("Clicked");
            }
            else if (parent.transform.GetChild(0) == Tile2 && parent.transform.GetChild(1) == Tile1)
            {
                Ans[2].CrossFadeAlpha(1, 2, false);
                Ans[3].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                cancelButton.interactable = false;
                nextButton.interactable = true;
                cancelImage.canvasRenderer.SetAlpha(0.0f);
                nextImage.CrossFadeAlpha(1, 1, false);
                qualified = true;
                if (answer2Complete)
                {
                    answersCompleted+=1;
                    answer2Complete = false;
                }
                Debug.Log("Clicked");
            }
            else
            {
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Debug.Log("Return");
            }

        }

        else
        {
            Tile1.transform.SetParent(parentToReturnTo);
            Tile2.transform.SetParent(parentToReturnTo);
            Debug.Log("Return");
        }
    }
    void Update()
    {
        StartCoroutine(Timer1());
        StartCoroutine(timesUp());
        
        if (answersCompleted == 2)
        {
            congratsPanel.SetActive(true);
            congratsAnim.SetTrigger("Start");
            answerPanel.SetActive(false);
            tilePanel.SetActive(false);
        }
    }

    IEnumerator timesUp()
    {
        yield return new WaitForSeconds(2f);

        if (timer > 0)
        {
            if (qualified)
            {
                congratsPanel.SetActive(true);
                congratsAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);
                Debug.Log("Congrats");
            }
            else
            {
                gameOverPanel.SetActive(true);
                gameOverAnim.SetTrigger("Start");
                answerPanel.SetActive(false);
                tilePanel.SetActive(false);

                for (int i = 0; i < Ans.Length; i++)
                {
                    Ans[i].canvasRenderer.SetAlpha(0.5f);
                }
                Debug.Log("Failed");
            }

        }
    }

    IEnumerator Timer1()
    {
        yield return new WaitForSeconds(1f);
        float timer = startTime;
        do
        {
            timer -= Time.deltaTime;
            timerSlider.fillAmount = (timer / startTime);
            //FormatText();
            minutes = (int)(timer / 60) % 60;
            seconds = (int)(timer % 60);
            string secondsString = seconds.ToString("00");
            string minutesString = minutes.ToString("0");
            timerText.text = minutesString + ":" + secondsString;
            yield return null;
            Debug.Log("Timer working");
        }
        while (timer > 0);
        
    }
}
