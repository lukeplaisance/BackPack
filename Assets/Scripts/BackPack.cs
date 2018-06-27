using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName ="BackPack")]
public class BackPack : ScriptableObject
{
    [SerializeField]
    private List<Item> _items;

    public List<Item> Items
    {
        get { return _items; }
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }
}
