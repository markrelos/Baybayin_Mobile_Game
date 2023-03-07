using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinsMasterScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI coinsText;
    int coinsGained;
    // Start is called before the first frame update
    void Start()
    {
        coinsGained = PlayerPrefs.GetInt("coinsTotal",0);
        coinsText.text = coinsGained.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinsGained = PlayerPrefs.GetInt("coinsTotal",0);
        coinsText.text = coinsGained.ToString();

    }
}
