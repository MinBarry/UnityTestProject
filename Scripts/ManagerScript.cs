using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

    public static ManagerScript Instance { get; private set; }  //presistant instane
    public float Edges=4f;         // to Limit the player movement on both sides
    public bool Pause = false;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
