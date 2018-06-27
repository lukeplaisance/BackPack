using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour {

    public Item item;

    private void Update()
    {
        var a = 1;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("BackPack"))
        {
            Debug.Log("backpacked");
            var bb = other.gameObject.GetComponent<BackPackBehaviour>();
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
