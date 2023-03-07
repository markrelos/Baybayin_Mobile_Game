using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessPanelScript : MonoBehaviour
{
    [SerializeField]
    AudioSource successAudiosource;
    public void audioPlay()
    {
        successAudiosource.Play();
    }
}
