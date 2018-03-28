using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1;
    //Shot type refrence
    public GameObject Shot;
    private bool shoot = false;
	
	void Start () {
		
	}
	
	void Update () {
        if (shoot)
        {
            Instantiate(Shot);
            Shot.transform.position = gameObject.transform.GetChild(0).position;
            shoot = false;
        }

    }

    private void OnMouseDrag()
    {
        Vector2 mousepoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousepoint.x <= ManagerScript.Instance.Edges && mousepoint.x >= -ManagerScript.Instance.Edges)
            transform.position = new Vector3(mousepoint.x * speed, transform.position.y, transform.position.z);
        shoot = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player trigger");
        Debug.Log(collision);
    }
}
