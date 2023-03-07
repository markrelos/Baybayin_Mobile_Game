using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelUnlockerPicto : MonoBehaviour
{
    [SerializeField]
    Button[] levelButtons;

    void Start()
    {
        int levelUnlockedPicto = PlayerPrefs.GetInt("PictolevelUnlocked", 1);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelUnlockedPicto)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

 
}
