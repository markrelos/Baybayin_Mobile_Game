using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuGameMaster : MonoBehaviour
{
    [SerializeField]
    GameObject[] Containers;

    int counter;
    int counterMod;
    // Start is called before the first frame update
    void Start()
    {
        Containers[0].SetActive(true);
        Containers[1].SetActive(false);
        Containers[2].SetActive(false);
        counter = 1;
        counterMod = counter % 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        counterMod = (counter) % 3;    
        if (counterMod == 1)
        {
            Containers[0].SetActive(true);
            Containers[1].SetActive(false);
            Containers[2].SetActive(false);
        }
       else if (counterMod == 2)
        {
            Containers[0].SetActive(false);
            Containers[1].SetActive(true);
            Containers[2].SetActive(false);
        }
        else if (counterMod == 0)
        {
            Containers[0].SetActive(false);
            Containers[1].SetActive(false);
            Containers[2].SetActive(true);
        }
    }

    public void NextContainer()
    {        
            counter += 1;         
    }
    public void PrevContainer()
    {
            counter -= 1;        
    }
}
