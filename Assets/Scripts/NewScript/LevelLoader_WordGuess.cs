using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader_WordGuess : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string introScene, Scene1, Scene2, Scene3, Scene4, Scene5;
    // Start is called before the first frame update
    IEnumerator LoadPictoLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }

    public void LoadScene1()
    {
        StartCoroutine(LoadPictoLevel(Scene1));
    }
    public void LoadScene2()
    {
        StartCoroutine(LoadPictoLevel(Scene2));
    }
    public void LoadScene3()
    {
        StartCoroutine(LoadPictoLevel(Scene3));
    }
    public void LoadScene4()
    {
        StartCoroutine(LoadPictoLevel(Scene4));
    }
    public void LoadScene5()
    {
        StartCoroutine(LoadPictoLevel(Scene5));
    }
   
}
