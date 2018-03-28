using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

    public static ManagerScript Instance { get; private set; }  //presistant instane
    public int Edges=4;         // to Limit the player movement on both sides

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
