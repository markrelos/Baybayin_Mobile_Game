using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadRefScene : MonoBehaviour
{
    // Start is called before the first frame update
  public void loadRef()
    {
        SceneManager.LoadScene("ReferenceScene");
    }
}
