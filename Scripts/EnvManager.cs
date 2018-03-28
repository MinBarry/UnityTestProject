using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to manage the environment
// Moves all environment objects, displays and updates player score and health
// and generates enemies and obstacles as children 
public class EnvManager : MonoBehaviour {

    public GameObject Player;

    private float  PlayerHealth;
    private float PlayerScore;
    private float TimePassed = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool pause = ManagerScript.Instance.Pause;
        if (!pause)
        {
            //update speed based on time passed
            TimePassed += Time.deltaTime;
            PlayerHealth = (Player.GetComponent("PlayerController") as PlayerController).Health;
            //if player health is zero stop the game
            //update score based on level speed
            //move env
        }

    }

    public void AddScore(float score)
    {
        PlayerScore += score;
        Debug.Log(PlayerScore);
    }

    private void GenerateEnv()
    {
        //populate env based on PlayerScore
    }

    private void StopGame()
    {
        // destroy player
        // play player destroyed animation
        // tell game manager that game is over
        // destroy all child objects 
    }
}
