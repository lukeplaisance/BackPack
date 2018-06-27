using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public partial class BackPackEditorWindow : UnityEditor.EditorWindow
{
    [UnityEditor.MenuItem("Tools/Backpack")]
    public static void Init()
    {
        var window = CreateInstance<BackPackEditorWindow>();
        window.Show();
    }
    public WindowItem item;
    public System.Collections.Generic.List<WindowItem> items = new System.Collections.Generic.List<WindowItem>();
    
    public void CreateItem()
    {
        items.Add(new WindowItem());
    }

    //public void DeletItem()
    //{
    //    items.Remove(item);
    //}

    private void OnGUI()
    {
        foreach (var item in items)
        {
            item.Draw();
            item.PollEvents();
        }
        Repaint();

        switch (Event.current.type)
        {
            case EventType.MouseDown:
                if (Event.current.button == 1)
                {
                    var gm = new UnityEditor.GenericMenu();
                    gm.AddItem(new GUIContent("Create Item Menu"), false, CreateItem);
                    gm.ShowAsContext();
                }
                break;
        }
    }
}
