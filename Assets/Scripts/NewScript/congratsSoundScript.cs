using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congratsSoundScript : MonoBehaviour
{
    [SerializeField]
    AudioSource congratulations;
    // Start is called before the first frame update


    // Update is called once per frame
    public void audioPlay()
    {
            congratulations.Play();    
    }
}
