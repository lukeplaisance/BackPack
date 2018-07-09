using System;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="BackPack")] [Serializable]
public class BackPack : ScriptableObject
{
    [SerializeField]
    private List<Item> _items = new List<Item>();

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
