using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript: ImpactObjectScript {

    public float Health = 1;
    public float ImpactDamage = 1;
	
	void Start () {
        DamageAmount = ImpactDamage;
	}
	
	void Update () {
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enemy collision");
        
    }
    protected void OnTriggerEnter2D(Collider2D other)
    {
        PlayerShotsScript shot = other.gameObject.GetComponent("PlayerShotsScript") as PlayerShotsScript;
        if (shot)
        {
            Health = Health - shot.getDamageAmount();
            Debug.Log(Health);
        }
        else if (other.gameObject.GetComponent("PlayerController"))
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        Debug.Log("Enemy Destroyed");
    }

}
