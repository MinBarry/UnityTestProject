using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class for objects that cause damage when they collide and get destroyed.
public class ImpactObjectScript : MonoBehaviour {

    protected float DamageAmount = 1;

    public float getDamageAmount(){return DamageAmount; }

	void Start () {
		
	}
	
	void Update () {

    }

    protected virtual void OnTriggerEnter2D()
    {
        //print("collision with impact obj");
        Destroy(gameObject);
    }
}
