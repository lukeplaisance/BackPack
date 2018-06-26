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
    public ItemData itemData;
    public System.Collections.Generic.List<Item> items = new System.Collections.Generic.List<Item>();

    public void CreateItem()
    {
        items.Add(new Item(Strings.SWORD));
    }

    //public void DeletItem()
    //{
    //    items.Remove(item);
    //}

    private void OnGUI()
    {
        foreach (var item in items)
        {
            itemData.Draw();
            itemData.PollEvents();
        }
        Repaint();

        switch (Event.current.type)
        {
            case EventType.MouseDown:
                if (Event.current.button == 1)
                {
                    var gm = new UnityEditor.GenericMenu();
                    gm.AddItem(new GUIContent("Create Item"), false, CreateItem);
                    //gm.AddItem(new GUIContent("Delete Item"), false, DeletItem);
                    gm.ShowAsContext();
                }
                break;
        }
    }
//}
