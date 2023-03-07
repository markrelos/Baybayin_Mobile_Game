
using UnityEngine;

public class buttonSound : MonoBehaviour
{
    [SerializeField]
    AudioSource playButtonSound;
    [SerializeField]
    AudioSource NextPrevSound;
    
    // Start is called before the first frame update
  

    // Update is called once per frame
  
    public void playClickSound()
    {
        playButtonSound.Play();
    }

    public void playNextPrevSound()
    {
        NextPrevSound.Play();
    }
}
