using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResetLevel()
    {
        PlayerPrefs.DeleteAll();
    }
}
