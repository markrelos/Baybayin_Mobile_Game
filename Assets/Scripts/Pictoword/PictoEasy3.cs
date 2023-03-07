using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PictoEasy3 : MonoBehaviour
{
    [SerializeField]
    Transform parent, parentToReturnTo;
    [SerializeField]
    Transform Tile1, Tile2, Tile3, Tile4, Tile5;
    [SerializeField]
    Image[] Ans;
    [SerializeField]
    Animator coinsFiveAnimation, congratsAnimation, coinsMinusFive, otherAnim, hintAnim;
    [SerializeField]
    GameObject coinsPanelFive, congratsPanel, ansPanel, tilePanel, coinsMinusFiveObj, otherPanel, hintPanel;
    [SerializeField]
    GameObject image1, image2, image1Panel, image2Panel, shuffleButton;
    [SerializeField]
    AudioSource correctSound, wrongSound;
    // Start is called before the first frame update
    void Start()
    {
        coinsPanelFive.SetActive(false);
        coinsMinusFiveObj.SetActive(false);
        otherPanel.SetActive(false);
        hintPanel.SetActive(false);
        for (int i = 0; i < Ans.Length; i++)
        {
            Ans[i].canvasRenderer.SetAlpha(0.0f);
        }
        image1Panel.SetActive(false);
        image2Panel.SetActive(false);
    }

    public void checkAnswers()
    {
        if (parent.childCount == 3)
        {
            if (parent.transform.GetChild(0) == Tile1 && parent.transform.GetChild(1) == Tile2 && parent.transform.GetChild(2) == Tile3)
            {
                Ans[0].CrossFadeAlpha(1, 2, false);
                Ans[1].CrossFadeAlpha(1, 2, false);
                Ans[2].CrossFadeAlpha(1, 2, false);
                Tile1.transform.SetParent(parentToReturnTo);
                Tile2.transform.SetParent(parentToReturnTo);
                Tile3.transform.SetParent(parentToReturnTo);
                if (PlayerPrefs.GetInt("Picto3Correct") == 0)
                {
                    PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") + 5);
                    PlayerPrefs.SetInt("Picto3Correct", 1);
                    PlayerPrefs.SetInt("PictolevelUnlocked", 4);
                    correctSound.Play();
                    StartCoroutine(coinsFivePanel());
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
        if (PlayerPrefs.GetInt("PictolevelUnlocked") > 3)
        {
            Ans[0].CrossFadeAlpha(1, 1, false);
            Ans[1].CrossFadeAlpha(1, 1, false);
            Ans[2].CrossFadeAlpha(1, 1, false);
            congratsPanel.SetActive(true);
            congratsAnimation.SetTrigger("Start");
            otherPanel.SetActive(true);
            otherAnim.SetTrigger("Start");
            ansPanel.SetActive(false);
            tilePanel.SetActive(false);
            shuffleButton.SetActive(false);
            //hintButton.SetActive(false);
        }
    }
    IEnumerator coinsFivePanel()
    {
        coinsPanelFive.SetActive(true);
        coinsFiveAnimation.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        coinsPanelFive.SetActive(false);
    }
    IEnumerator coinsMinusFivePanel()
    {
        coinsMinusFiveObj.SetActive(true);
        coinsMinusFive.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        coinsMinusFiveObj.SetActive(false);
    }

    public void image1Activate()
    {
        image1.SetActive(false);
        image2.SetActive(false);
        image1Panel.SetActive(true);
    }
    public void image1Deactivate()
    {
        image1.SetActive(true);
        image2.SetActive(true);
        image1Panel.SetActive(false);
    }
    public void image2Activate()
    {
        image1.SetActive(false);
        image2.SetActive(false);
        image2Panel.SetActive(true);
    }
    public void image2Deactivate()
    {
        image1.SetActive(true);
        image2.SetActive(true);
        image2Panel.SetActive(false);
    }

    public void HintButton()
    {
        if (PlayerPrefs.GetInt("Picto3Correct") == 0)
        {
            if (PlayerPrefs.GetInt("coinsTotal") >= 30)
            {
                PlayerPrefs.SetInt("coinsTotal", PlayerPrefs.GetInt("coinsTotal") - 30);
                PlayerPrefs.SetInt("Picto3Correct", 1);
                PlayerPrefs.SetInt("PictolevelUnlocked", 4);
                StartCoroutine(coinsMinusFivePanel());
                closeHint();
                Debug.Log("Hint");
            }
            else
            {
                wrongSound.Play();
            }
        }
        else
        {
            wrongSound.Play();
        }
    }
    IEnumerator hintPanelAnim()
    {
        yield return new WaitForSeconds(0f);
        hintPanel.SetActive(true);
        hintAnim.SetTrigger("Start");
    }
    public void HintMain()
    {
        StartCoroutine(hintPanelAnim());
    }
    public void closeHint()
    {
        hintPanel.SetActive(false);
    }
}
