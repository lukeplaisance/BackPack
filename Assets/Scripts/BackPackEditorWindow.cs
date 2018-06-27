using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//public partial class BackPackEditorWindow : UnityEditor.EditorWindow
//{
//    [UnityEditor.MenuItem("Tools/Backpack")]
//    public static void Init()
//    {
//        var window = CreateInstance<BackPackEditorWindow>();
//        window.Show();
//    }
//    public Item itemData;

//    //public void CreateItem()
//    //{
//    //    items.Add(new Item());
//    //}

//    private void OnGUI()
//    {
//        //foreach (var item in items)
//        //{
//        //    itemData.Draw();
//        //    itemData.PollEvents();
//        //}
//        //Repaint();

//        switch (Event.current.type)
//        {
//            case EventType.MouseDown:
//                if (Event.current.button == 1)
//                {
//                    var gm = new UnityEditor.GenericMenu();
//                    gm.AddItem(new GUIContent("Create Item"), false, CreateItem);
//                    gm.ShowAsContext();
//                }
//                break;
//        }
//    }
//}
