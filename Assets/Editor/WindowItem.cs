using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowItem
{
    public Rect itemRect = new UnityEngine.Rect(x: 25, y: 25, width: 140, height: 230);
    public bool isSelected = false;
    public void PollEvents()
    {
        switch (Event.current.type)
        {
            case EventType.MouseDown:
                if (Event.current.button == 0)
                {
                    if (itemRect.Contains(Event.current.mousePosition))
                    {
                        isSelected = true;
                        GUI.changed = true;
                    }
                    else
                    {
                        isSelected = false;
                        GUI.changed = true;
                    }
                }
                break;
            case EventType.MouseDrag:
                if (Event.current.button == 0)
                {
                    if (isSelected)
                    {
                        itemRect.position += Event.current.delta;
                        Event.current.Use();
                    }
                }
                break;
        }
    }
    public GameObject prefab;
    public void Draw()
    {
        var itemContent = new Rect(itemRect);
        GUI.Box(itemRect, "Item");
        GUILayout.BeginArea(itemContent);
        if(GUI.Button(new Rect(x: 10, y: 20, width: 100, height: 30), "Comabt Knife"))
        {
            Debug.Log("combat knife click");
        }
        GUI.Button(new Rect(x: 10, y: 60, width: 100, height: 30), "Baretta M9");
        GUI.Button(new Rect(x: 10, y: 100, width: 100, height: 30), "Kevlar Vest");
        GUI.Button(new Rect(x: 10, y: 140, width: 100, height: 30), "Health Potion");
        GUI.Button(new Rect(x: 10, y: 180, width: 100, height: 30), "Antidote");
        GUILayout.EndArea();
    }

}
