using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeSettings : MonoBehaviour
{
    public void theme1()
    {
        PlayerPrefs.SetInt("themeSelector", 0);
    }
    public void theme2()
    {
        PlayerPrefs.SetInt("themeSelector", 1);
    }

    public void theme3()
    {
        PlayerPrefs.SetInt("themeSelector", 2);
    }
    public void theme4()
    {
        PlayerPrefs.SetInt("themeSelector", 3);
    }
}
