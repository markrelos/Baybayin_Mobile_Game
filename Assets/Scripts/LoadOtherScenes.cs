using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOtherScenes : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string otherScene, MainMenuScene;



    public void LoadOtherScene()
    {
        StartCoroutine(LoadLevel(otherScene));
    }
    public void LoadMainMenu()
    {
        StartCoroutine(LoadLevel(MainMenuScene));
    }
    IEnumerator LoadLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }
}
