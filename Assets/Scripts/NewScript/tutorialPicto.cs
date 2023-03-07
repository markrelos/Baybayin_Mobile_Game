using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tutorialPicto : MonoBehaviour
{
    [SerializeField]
    Image[] Ans;
    [SerializeField]
    Transform Tile1, Tile2;
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    GameObject[] gameButtons;
    [SerializeField]
    AudioSource correctSound;
    [SerializeField]
    GameObject image1Large;
    [SerializeField]
    GameObject hand2, hand3, hand31, hand4, hand5, hand6, hand8, hand9, hand10, hand11;

    // Start is called before the first frame update
    void Start()
    {
        Ans[0].canvasRenderer.SetAlpha(0.0f);
        Ans[1].canvasRenderer.SetAlpha(0.0f);

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
        hand2.SetActive(true);
    }
    public void button2()
    {
        hand2.SetActive(false);
        gameButtons[1].SetActive(false);
        gameButtons[2].SetActive(true);
        hand3.SetActive(true);
        hand31.SetActive(true);
    }
    public void button3()
    {
        hand3.SetActive(false);
        hand31.SetActive(false);
        gameButtons[2].SetActive(false);
        gameButtons[3].SetActive(true);
        hand4.SetActive(true);
    }
    public void button4()
    {
        hand4.SetActive(false);
        image1Large.SetActive(true);
        gameButtons[3].SetActive(false);
        gameButtons[4].SetActive(true);
        hand5.SetActive(true);
    }
    public void button5()
    {
        hand5.SetActive(false);
        image1Large.SetActive(false);
        gameButtons[4].SetActive(false);
        gameButtons[5].SetActive(true);
        hand6.SetActive(true);
    }
    public void button6()
    {
        hand6.SetActive(false);
        gameButtons[5].SetActive(false);
        gameButtons[6].SetActive(true);
    }
    public void button7()
    {        
        gameButtons[6].SetActive(false);
        gameButtons[7].SetActive(true);
        hand8.SetActive(true);
    }
    public void button8()
    {
        hand8.SetActive(false);
        Tile1.transform.SetParent(parent);
        gameButtons[7].SetActive(false);
        gameButtons[8].SetActive(true);
        hand9.SetActive(true);
    }
    public void button9()
    {
        hand9.SetActive(false);
        Tile2.transform.SetParent(parent);
        gameButtons[8].SetActive(false);
        gameButtons[9].SetActive(true);
        hand10.SetActive(true);
    }
    public void button10()
    {
        hand10.SetActive(false);
        correctSound.Play();
        Ans[0].canvasRenderer.SetAlpha(1f);
        Ans[1].canvasRenderer.SetAlpha(1f);
        Tile1.transform.SetParent(parentToReturnTo);
        Tile2.transform.SetParent(parentToReturnTo);
        gameButtons[9].SetActive(false);
        gameButtons[10].SetActive(true);
        hand11.SetActive(true);
    }
    public void button11()
    {
        hand11.SetActive(false);
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
        PlayerPrefs.SetInt("isFirstTimePicto", 1);
        SceneManager.LoadScene("LevelLoader_Picto");
    }


    public void SkipTut()
    {
        PlayerPrefs.SetInt("isFirstTimePicto", 1);
        SceneManager.LoadScene("LevelLoader_Picto");
    }


}
