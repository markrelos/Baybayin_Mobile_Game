using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string scenename, otherScene;



    public void LoadScene()
    {
         StartCoroutine(LoadLevel(scenename));           
    }

    IEnumerator LoadLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }

    public void LoadOtherScene()
    {
        StartCoroutine(LoadOtherLevel(otherScene));
    }

    IEnumerator LoadOtherLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }

}