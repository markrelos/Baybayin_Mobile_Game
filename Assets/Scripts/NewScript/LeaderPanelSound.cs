using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderPanelSound : MonoBehaviour
{
    [SerializeField]
    AudioSource leaderAudio;
    [SerializeField]
    string levelScene, leaderboardScene, homeScene;

    public void audioPlay()
    {
        leaderAudio.Play();
    }

    public void tryAgain()
    {
        SceneManager.LoadScene(levelScene);
    }
    public void leaderBoard()
    {
        SceneManager.LoadScene(leaderboardScene);
    }
    public void home()
    {
        SceneManager.LoadScene(homeScene);
    }
}
   
