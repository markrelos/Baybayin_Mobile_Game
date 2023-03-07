using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimedTutScript : MonoBehaviour
{
    [SerializeField]
    Image[] Ans;
    [SerializeField]
    GameObject nextButton, coinsPanelOne, coinsPanelFive, hintPanel, newLvlPanel, successPanel, perfectPanel, otherPanel;
    [SerializeField]
    GameObject[] gameButtons;
    [SerializeField]
    GameObject Tile1, Tile2;
    [SerializeField]
    AudioSource correctSound;

    // Start is called before the first frame update
    void Start()
    {
        Ans[0].canvasRenderer.SetAlpha(0.0f);
        Ans[1].canvasRenderer.SetAlpha(0.0f);
        Ans[2].canvasRenderer.SetAlpha(0.0f);
        Ans[3].canvasRenderer.SetAlpha(0.0f);
        Ans[4].canvasRenderer.SetAlpha(0.0f);

        nextButton.SetActive(false);
        coinsPanelOne.SetActive(false);
        coinsPanelFive.SetActive(false);
        hintPanel.SetActive(false);
        newLvlPanel.SetActive(false);
        successPanel.SetActive(false);
        perfectPanel.SetActive(false);
        otherPanel.SetActive(false);

        for (int i = 0; i < gameButtons.Length; i++)
        {
            gameButtons[i + 1].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void button1()
    {
        gameButtons[0].SetActive(false);
        gameButtons[1].SetActive(true);
    }
    public void button2()
    {
        gameButtons[1].SetActive(false);
        gameButtons[2].SetActive(true);
    }
    public void button3()
    {
        gameButtons[2].SetActive(false);
        gameButtons[3].SetActive(true);
    }
    public void button4()
    {
        gameButtons[3].SetActive(false);
        gameButtons[4].SetActive(true);
    }
    public void button5()
    {
        Tile1.SetActive(false);
        Tile2.SetActive(false);
        gameButtons[4].SetActive(false);
        gameButtons[5].SetActive(true);
    }
    public void button6()
    {

        gameButtons[5].SetActive(false);
        gameButtons[6].SetActive(true);
    }
    public void button7()
    {   
        gameButtons[6].SetActive(false);
        gameButtons[7].SetActive(true);
    }
    public void button8()
    {
        correctSound.Play();
        Ans[3].canvasRenderer.SetAlpha(1f);
        Ans[4].canvasRenderer.SetAlpha(1f);
        Tile1.SetActive(true);
        Tile2.SetActive(true);
        gameButtons[7].SetActive(false);
        gameButtons[8].SetActive(true);
    }
    public void button9()
    {
        gameButtons[8].SetActive(false);
        gameButtons[9].SetActive(true);
    }
    public void button10()
    {
        gameButtons[9].SetActive(false);
        gameButtons[10].SetActive(true);
    }
    public void button11()
    {
        nextButton.SetActive(true);
        gameButtons[10].SetActive(false);
        gameButtons[11].SetActive(true);
    }
    public void button12()
    {
        gameButtons[11].SetActive(false);
        gameButtons[12].SetActive(true);
    }
    public void button13()
    {
        gameButtons[12].SetActive(false);
        gameButtons[13].SetActive(true);
    }
    public void button14()
    {
        gameButtons[13].SetActive(false);
        gameButtons[14].SetActive(true);
    }
    public void button15()
    {
        gameButtons[14].SetActive(false);
        gameButtons[15].SetActive(true);

    }
    public void button16()
    {
        PlayerPrefs.SetInt("isFirstTimeTimed", 1);
        SceneManager.LoadScene("Timed_1");
    }

    public void SkipTut()
    {
        PlayerPrefs.SetInt("isFirstTimeTimed", 1);
        SceneManager.LoadScene("Timed_1");
    }


}
