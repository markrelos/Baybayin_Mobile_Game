using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadTutScenePicto : MonoBehaviour
{
    public string tutScene;
    void Start()
    {
        if (PlayerPrefs.GetInt("isFirstTimePicto", 0) == 0)
        {
            SceneManager.LoadScene(tutScene);
            Debug.Log(PlayerPrefs.GetInt("isFirstTimePicto", 0));
        }
        else
        {
            Debug.Log(PlayerPrefs.GetInt("isFirstTimePicto", 0));
        }
    }

}
