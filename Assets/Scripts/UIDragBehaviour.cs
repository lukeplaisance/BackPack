using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDragBehaviour : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData pointerEventData)
    {
        var rectTransform = GetComponent<RectTransform>();
        var move = new Vector3(pointerEventData.delta.x, pointerEventData.delta.y, 0);
        rectTransform.position += move;
    }
}
