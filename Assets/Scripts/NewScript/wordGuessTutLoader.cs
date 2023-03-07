using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wordGuessTutLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("isFirstTimeWordGuess") == 0)
        {
            SceneManager.LoadScene("WordGuessTutorial");
        }

    }
}
