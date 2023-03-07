using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class otherGameModesTimed : MonoBehaviour
{
    public string Scene1, Scene11, Scene2, Scene21, Scene3;
    // Start is called before the first frame update
    public void firstScene()
    {
        if (PlayerPrefs.GetInt("isFirstTimeUntimed") == 0)
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
        if (PlayerPrefs.GetInt("isFirstTimePicto") == 0)
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
        SceneManager.LoadScene(Scene3);
    }
}
