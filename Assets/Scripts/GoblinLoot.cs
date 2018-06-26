﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName ="LootTable")]
public class GoblinLoot : ScriptableObject
{
    [SerializeField]
    private List<Item> items;

    public void Add(Item item)
    {
        items.Add(item);
    }

    public void Remove(Item item)
    {
        items.Remove(item);
    }
	
}
