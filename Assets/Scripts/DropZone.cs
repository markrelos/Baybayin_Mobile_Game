﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    public void OnPointerExit(PointerEventData eventData)
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        Draggable drag = eventData.pointerDrag.GetComponent<Draggable>();
        if (drag != null)
        {
            drag.parentToReturnTo = this.transform;
        }
    }
}
