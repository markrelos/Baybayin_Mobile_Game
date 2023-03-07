using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSelectorScript : MonoBehaviour
{
    static ThemeSelectorScript themeManagerInstance;

    [HideInInspector]
    public GameObject bg;
    public Sprite themeOneSprite;
    public Sprite themeTwoSprite;
    public Sprite themeThreeSprite;
    public Sprite themeFourSprite;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (themeManagerInstance == null)
        {
            themeManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        bg = GameObject.Find("Background");
        UpdateTheme();
    }

    void UpdateTheme()
    {
        if (PlayerPrefs.GetInt("themeSelector", 0) == 0)
        {
            bg.GetComponent<Image>().sprite = themeOneSprite;
        }
        else if(PlayerPrefs.GetInt("themeSelector", 0) == 1)
        {
            bg.GetComponent<Image>().sprite = themeTwoSprite;
        }
        else if (PlayerPrefs.GetInt("themeSelector", 0) == 2)
        {
            bg.GetComponent<Image>().sprite = themeThreeSprite;
        }
        else if (PlayerPrefs.GetInt("themeSelector", 0) == 3)
        {
            bg.GetComponent<Image>().sprite = themeFourSprite;
        }
    }
}
