using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = ("RatGun"))]
public class BazookaRatGun : Item
{
    public GameObject ratProjectile;
    public override void Use()
    {
        Debug.Log("pew pew");
        var rt = ratProjectile.GetComponent<Rigidbody>();
        for (int i = 0; i < 100; i++)
        {
            Instantiate(ratProjectile);
            rt.AddForce(Vector3.right);
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
