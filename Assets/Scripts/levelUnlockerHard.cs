using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelUnlockerHard : MonoBehaviour
{
    [SerializeField]
    Button[] levelButtons;
    // Start is called before the first frame update
    void Start()
    {
        int levelUnlocked = PlayerPrefs.GetInt("levelUnlocked", 1);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 11 > levelUnlocked)
            {
                levelButtons[i].interactable = false;
            }
        }
    }
}
