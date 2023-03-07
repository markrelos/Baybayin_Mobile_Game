using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countdownTimer : MonoBehaviour
{
    [SerializeField]
    float startTime = 30f;
    [SerializeField]
    Image timerSlider;
    [SerializeField]
    public TextMeshProUGUI timerText;
    public int minutes; 
    public float seconds;
    float timer = 0f;
    public checkBaka checkBakaIns;
    // Start is called before the first frame update
    void Start()
    {
        
        timerText.text = minutes.ToString() + ":" + seconds.ToString();
    }

    public IEnumerator Timer1()
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
        }
        while (checkBakaIns.answersCompleted < 3);
    }

    private void Update()
    {
        StartCoroutine(Timer1());
    }

}
