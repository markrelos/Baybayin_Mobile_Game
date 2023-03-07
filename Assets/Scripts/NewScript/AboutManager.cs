using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AboutManager : MonoBehaviour
{
    [SerializeField]
    GameObject aboutObj, creditsObj;
    // Start is called before the first frame update
    void Start()
    {
        creditsObj.SetActive(false);
    }

    // Update is called once per frame
   public void showCredits()
    {
        creditsObj.SetActive(true);
        aboutObj.SetActive(false);
    }
    public void showAbout()
    {
        creditsObj.SetActive(false);
        aboutObj.SetActive(true);
    }

    public void goHomeIntro()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
