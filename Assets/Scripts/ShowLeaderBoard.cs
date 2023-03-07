using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowLeaderBoard : MonoBehaviour
{
    [SerializeField]
    //TextMeshProUGUI championName, championScore, secondName, secondScore, thirdName, thirdScore, fourthName, fourthScore, fifthName, fifthScore;
    TextMeshProUGUI[] leaderName, leaderScore;
    // Start is called before the first frame update
    private void Update()
    {

        for (int i = 0; i < Leaderboards.EntryCount; i++)
        {
            var entry = Leaderboards.GetEntry(i);
            leaderName[i].text = entry.name;
            leaderScore[i].text = entry.score.ToString();
        }
    }


}
