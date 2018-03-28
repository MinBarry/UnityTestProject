using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to control the player's movement, and updates health
// Should be attached to a player type prefab.
public class PlayerController : MonoBehaviour {

    public float verticalSpeed = 1;
    public float Health = 10;   
    public GameObject Shot;     //Shot type refrence

    private bool shoot = false;
	
	void Start () {
		
	}
	
	void Update () {
        // Create shots
        if (shoot)
        {
            Instantiate(Shot);
            Shot.transform.position = gameObject.transform.GetChild(0).position;
            shoot = false;
        }

    }

    private void OnMouseDrag()
    {
        //Dragging player with the mouse
        Vector2 mousepoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousepoint.x <= ManagerScript.Instance.Edges && mousepoint.x >= -ManagerScript.Instance.Edges) //Check edges to limit player position
            transform.position = new Vector3(mousepoint.x * verticalSpeed, transform.position.y, transform.position.z);
        shoot = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player trigger");
        Debug.Log(collision);
        //Update player health
    }
}
