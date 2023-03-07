using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordTwistMenuTutLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0f;
    [SerializeField]
    string UntimedTut, TimedTut, untimedScene, timedScene;



    public void LoadScene()
    {
        if (PlayerPrefs.GetInt("isFirstTimeUntimed") == 0)
        {
            StartCoroutine(LoadLevel(UntimedTut));
        }
        else
        {
            StartCoroutine(LoadLevel(untimedScene));
        }
    }

    IEnumerator LoadLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }

    public void LoadOtherScene()
    {
        if (PlayerPrefs.GetInt("isFirstTimeTimed") == 0)
        {
            StartCoroutine(LoadLevel(TimedTut));
        }
        else
        {
            StartCoroutine(LoadLevel(timedScene));
        }
    }

    IEnumerator LoadOtherLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }

    public void LoadTutUntimed()
    {
        StartCoroutine(LoadOtherLevel(UntimedTut));
    }
    public void LoadTutTimed()
    {
        StartCoroutine(LoadOtherLevel(TimedTut));
    }
}
