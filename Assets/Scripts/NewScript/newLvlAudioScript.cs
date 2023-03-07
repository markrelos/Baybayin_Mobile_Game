using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLvlAudioScript : MonoBehaviour
{
    [SerializeField]
    AudioSource newLvlAudiosource;
    public void audioPlay()
    {
        newLvlAudiosource.Play();
    }
}
