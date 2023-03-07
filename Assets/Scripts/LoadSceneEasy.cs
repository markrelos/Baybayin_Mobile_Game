using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneEasy : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string previousScene, nextScene, Scene1, Scene2, Scene3, Scene4, Scene5;



    public void LoadPreviousScene()
    {
        StartCoroutine(LoadLevel(previousScene));
    }
    public void LoadNextScene()
    {
        StartCoroutine(LoadLevel(nextScene));
    }

    IEnumerator LoadLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }

    public void LoadScene1()
    {
        StartCoroutine(LoadOtherLevel(Scene1));
    }
    public void LoadScene2()
    {
        StartCoroutine(LoadOtherLevel(Scene2));
    }
    public void LoadScene3()
    {
        StartCoroutine(LoadOtherLevel(Scene3));
    }
    public void LoadScene4()
    {
        StartCoroutine(LoadOtherLevel(Scene4));
    }
    public void LoadScene5()
    {
        StartCoroutine(LoadOtherLevel(Scene5));
    }
    IEnumerator LoadOtherLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }

}
