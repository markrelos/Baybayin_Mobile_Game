using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleTextScript : MonoBehaviour
{
    [SerializeField]
    GameObject image1, image2, button1, button2;
    // Start is called before the first frame update
    void Start()
    {
        image2.SetActive(false);
        button2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goHome()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void nextImage()
    {
        image1.SetActive(false);
        button1.SetActive(false);
        image2.SetActive(true);
        button2.SetActive(true);
    }
    public void prevImage()
    {
        image1.SetActive(true);
        button1.SetActive(true);
        image2.SetActive(false);
        button2.SetActive(false);
    }
}
