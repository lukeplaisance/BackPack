using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour {

    public Item item;
    private Vector3 offset;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("BackPack"))
        {
            var bb = other.GetComponent<BackPackBehaviour>();
            bb.Inventory.Add(item);
        }
    }

    private void OnMouseDown()
    {
    }
    private void OnMouseDrag()
    {

    }
}
