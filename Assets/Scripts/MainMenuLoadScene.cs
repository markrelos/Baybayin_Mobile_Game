using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoadScene : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0f;
    public string sceneOne, sceneTwo, sceneThree;



    public void LoadSceneOne()
    {
        StartCoroutine(LoadLevel(sceneOne));
    }
    public void LoadSceneTwo()
    {
        StartCoroutine(LoadLevel(sceneTwo));
    }
    public void LoadSceneThree()
    {
        StartCoroutine(LoadLevel(sceneThree));
    }

    IEnumerator LoadLevel(string scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }


}
