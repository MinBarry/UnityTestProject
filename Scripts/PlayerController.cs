using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnMouseDrag()
    {
        Vector2 mousepoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Debug.Log(mousepoint.x);

        if (mousepoint.x <= ManagerScript.Instance.Edges && mousepoint.x >= -ManagerScript.Instance.Edges)
            transform.position = new Vector3(mousepoint.x * speed, transform.position.y, transform.position.z);
        else
            Debug.Log("Shouldnt move");
    }
}
