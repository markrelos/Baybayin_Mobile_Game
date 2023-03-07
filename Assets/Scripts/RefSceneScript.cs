using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefSceneScript : MonoBehaviour
{
    [SerializeField]
    GameObject ref1, ref2, ref3, prevButton, prev2Button, nextButton, next2Button;
    // Start is called before the first frame update
    void Start()
    {
        ref2.SetActive(false);
        ref3.SetActive(false);
        prevButton.SetActive(false);
        prev2Button.SetActive(false);
        next2Button.SetActive(false);
    }

   public void showNextReference()
    {
        ref1.SetActive(false);
        ref2.SetActive(true);
        nextButton.SetActive(false);
        prevButton.SetActive(true);
        next2Button.SetActive(true);
    }
    public void showPrevReference()
    {
        ref1.SetActive(true);
        ref2.SetActive(false);
        nextButton.SetActive(true);
        prevButton.SetActive(false);
        next2Button.SetActive(false);
    }
    public void showNext2Reference()
    {
        ref2.SetActive(false);
        ref3.SetActive(true);
        next2Button.SetActive(false);
        prev2Button.SetActive(true);
    }
    public void showPrev2Reference()
    {
        ref2.SetActive(true);
        ref3.SetActive(false);
        next2Button.SetActive(true);
        prevButton.SetActive(true);
        prev2Button.SetActive(false);
    }

}
