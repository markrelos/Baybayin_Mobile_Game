using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour
{
    
    Transform parent = null;
    Transform parentToReturnTo = null;
    private void Awake()
    {
        parent = GameObject.Find("TileHolder").transform;
        parentToReturnTo = GameObject.Find("AnswerHolder").transform;
    }
    public void moveTiles()
    {
        if (this.transform.parent == parentToReturnTo)
        {
            this.transform.SetParent(parent);
        }
        else
        {
            this.transform.SetParent(parentToReturnTo);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
