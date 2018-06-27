using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour {

    public Item item;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("Player"))
        {
            var bb = other.GetComponent<BackPackBehaviour>();
            bb.Inventory.Add(item);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
