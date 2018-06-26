using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Item : ScriptableObject
{
    public Sprite image;

    public virtual void Use()
    {

    }

    //private string _name;
    //public string Name
    //{
    //   get { return _name; }
    //   set { _name = value; }
    //}

    //public Item(string name)
    //{
    //   Name = name;
    //}
}

