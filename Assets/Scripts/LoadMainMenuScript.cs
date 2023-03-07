using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void LoadIntro()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadLeader()
    {
        SceneManager.LoadScene("LeaderboardScene");
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("TutorialScene");
    }
    public void LoadSampleTextScene()
    {
        SceneManager.LoadScene("SampleTextScene");
    }
    public void LoadReferenceScene()
    {
        SceneManager.LoadScene("ReferenceScene");
    }
    public void LoadAboutScene()
    {
        SceneManager.LoadScene("AboutScene");
    }

    private void Update()
    {
        if(PlayerPrefs.GetInt("isFirstTime") == 0)
        {
            SceneManager.LoadScene("TutorialScene");
            PlayerPrefs.SetInt("isFirstTime", 1);
        }
    }

    
}
