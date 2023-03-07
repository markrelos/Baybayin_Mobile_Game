using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class referenceShow : MonoBehaviour
{
    [SerializeField]
    GameObject ref1, ref2;
    bool isRefShowing;
    private void Start()
    {
        ref1.SetActive(false);
        ref2.SetActive(false);
        isRefShowing = false;
    }
    public void showRef()
    {
        if (isRefShowing == false)
        {
            ref1.SetActive(true);
            isRefShowing = true;
        }
        else if(isRefShowing)
        {
            ref1.SetActive(false);
            ref2.SetActive(false);
            isRefShowing = false;
        }
    }
    public void showNextRef()
    {
        ref1.SetActive(false);
        ref2.SetActive(true);
    }
    public void showPrevRef()
    {
        ref2.SetActive(false);
        ref1.SetActive(true);
    }
}
