using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelUnlockerAverage : MonoBehaviour
{
    [SerializeField]
    Button[] levelButtons;
    //[SerializeField]
    //GameObject nextButton;
    //[SerializeField]
    //Button nextButt;
    //[SerializeField]
    //Image nextImage;
    // Start is called before the first frame update
    
    void Start()
    {
        int levelUnlocked = PlayerPrefs.GetInt("levelUnlocked", 1);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 6 > levelUnlocked)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        int levelUnlocked = PlayerPrefs.GetInt("levelUnlocked");
        if (levelUnlocked < 11)
        {
            nextButt.interactable = false;
            nextImage.canvasRenderer.SetAlpha(0.0f);
            nextButton.SetActive(false);
        }

    }*/
}
