using UnityEngine;

public partial class BackPackEditorWindow
{
    public class ItemData
    {
        Item item;
        public Rect itemRect = new UnityEngine.Rect(x: 25, y: 25, width: 150, height: 150);
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
        public void Draw()
        {
            var itemContent = new Rect(itemRect);
            GUI.Box(itemRect, "Sword");
            GUILayout.BeginArea(itemContent);
            GUILayout.EndArea();
        }
    }
}
