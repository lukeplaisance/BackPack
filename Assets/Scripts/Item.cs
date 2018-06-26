﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Item(string name)
    {
        Name = name;
    }
}
