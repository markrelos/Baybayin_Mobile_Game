using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameMaster : MonoBehaviour
{
    [SerializeField]
    Image shuffleImage, enterImage;
    public Button shuffleButton, enterButton;
    [SerializeField]
    Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        enterImage.canvasRenderer.SetAlpha(0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (parent.childCount > 0)
        {
            shuffleButton.interactable = false;
            shuffleImage.CrossFadeAlpha(0, 0.2f, false);
            enterButton.interactable = true;
            enterImage.CrossFadeAlpha(1, 0.2f, false);
        }
        else
        {
            if (parent.childCount == 0)
            {
                shuffleButton.interactable = true;
                shuffleImage.CrossFadeAlpha(1, 0.2f, false);
                enterButton.interactable = false;
                enterImage.CrossFadeAlpha(0, 0.2f, false);
            }
        }
    }   

}
