using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReferenceMaster : MonoBehaviour
{
    [SerializeField]
    GameObject[] References;

    [SerializeField]
    GameObject closeButton, nextButton, prevButton;

    [SerializeField]
    GameObject refHolder;

    int counter;
    int counterMod;
    // Start is called before the first frame update
    void Start()
    {
        References[0].SetActive(false);
        References[1].SetActive(false);
        References[2].SetActive(false);
        closeButton.SetActive(false);
        nextButton.SetActive(false);
        prevButton.SetActive(false);
        refHolder.SetActive(false);
        counter = 1;
        counterMod = counter % 3;

    }

    // Update is called once per frame
    void Update()
    {
        counterMod = (counter) % 3;
        if(counter < 1)
        {
            counter = 1;
        }

        if (counterMod == 1)
        {
            References[0].SetActive(true);
            References[1].SetActive(false);
            References[2].SetActive(false);
        }
        else if (counterMod == 2)
        {
            References[0].SetActive(false);
            References[1].SetActive(true);
            References[2].SetActive(false);
        }
        else if (counterMod == 0)
        {
            References[0].SetActive(false);
            References[1].SetActive(false);
            References[2].SetActive(true);
        }
    }

    public void NextReference()
    {
        counter += 1;
    }
    public void PrevReference()
    {
        counter -= 1;
    }

    public void CloseRef()
    {
        refHolder.SetActive(false);
    }

    public void mainRefButton()
    {
        refHolder.SetActive(true);
        References[0].SetActive(true);
        closeButton.SetActive(true);
        nextButton.SetActive(true);
        prevButton.SetActive(true);
    }
}
