using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    float transitionTime = 3f;
    public string sceneMain;
   

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(loadMainMenu(sceneMain));
    }

    IEnumerator loadMainMenu(string sceneName)
    {
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneName);
    }
}
