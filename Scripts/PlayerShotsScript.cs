using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotsScript : ImpactObjectScript{

    public float ShotDamage = 1;

	void Start () {
        //setting the parent DamageAmount, which is used by other classes to refer damage
        DamageAmount = ShotDamage;
    }
	
	void Update () {
        //Update position
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.5f);
    }

}
