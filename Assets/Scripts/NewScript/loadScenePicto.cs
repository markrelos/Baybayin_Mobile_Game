using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScenePicto : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string introScene, tutScene, Scene1, Scene2, Scene3, Scene4, Scene5, Scene6, Scene7, Scene8, Scene9, Scene10, Scene11, Scene12, Scene13, Scene14, Scene15;
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
    public void LoadScene6()
    {
        StartCoroutine(LoadPictoLevel(Scene6));
    }
    public void LoadScene7()
    {
        StartCoroutine(LoadPictoLevel(Scene7));
    }
    public void LoadScene8()
    {
        StartCoroutine(LoadPictoLevel(Scene8));
    }
    public void LoadScene9()
    {
        StartCoroutine(LoadPictoLevel(Scene9));
    }
    public void LoadScene10()
    {
        StartCoroutine(LoadPictoLevel(Scene10));
    }
    public void LoadScene11()
    {
        StartCoroutine(LoadPictoLevel(Scene11));
    }
    public void LoadScene12()
    {
        StartCoroutine(LoadPictoLevel(Scene12));
    }
    public void LoadScene13()
    {
        StartCoroutine(LoadPictoLevel(Scene13));
    }
    public void LoadScene14()
    {
        StartCoroutine(LoadPictoLevel(Scene14));
    }
    public void LoadScene15()
    {
        StartCoroutine(LoadPictoLevel(Scene15));
    }
    public void LoadScene16()
    {
        StartCoroutine(LoadPictoLevel(introScene));
    }
    public void LoadtutScene()
    {
        StartCoroutine(LoadPictoLevel(tutScene));
    }
}
