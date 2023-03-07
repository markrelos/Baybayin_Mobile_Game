using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Next : MonoBehaviour
{
    public GameObject panel1, panel2, panel3;
    public Animator animateLoadPanel;
    public void LoadNextPanel()
    {
        Debug.Log("Clicked Next");
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        animateLoadPanel.SetTrigger("Start");
        Debug.Log("Clicked Next");
    }
}
