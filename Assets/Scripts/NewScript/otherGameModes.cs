using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class otherGameModes : MonoBehaviour
{
    public string Scene1, Scene11, Scene2, Scene21, Scene3, Scene31;
    // Start is called before the first frame update
    public void firstScene()
    {
        if (PlayerPrefs.GetInt("isFirstTimeTimed") == 0)
        {
           SceneManager.LoadScene(Scene11);
        }
        else
        {
            SceneManager.LoadScene(Scene1);
        }
    }
    public void secondScene()
    {
        if (PlayerPrefs.GetInt("isFirstTimeUntimed") == 0)
        {
            SceneManager.LoadScene(Scene21);
        }
        else
        {
            SceneManager.LoadScene(Scene2);
        }
    }
    public void thirdScene()
    {
        if (PlayerPrefs.GetInt("isFirstTimeWordGuess") == 0)
        {
            SceneManager.LoadScene(Scene31);
        }
        else
        {
            SceneManager.LoadScene(Scene3);
        }
    }
}
