using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerSpawner : MonoBehaviour {

    public GameObject playerPrefab;
    GameObject playerInstance;

    float respawnTimer;
    public int numberOfLives = 4;
	// Use this for initialization
	void Start () {
        SpawnPlayer(); 
    }
    void SpawnPlayer() {
        numberOfLives--;
        respawnTimer = 1;
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update () {
        if (playerInstance == null) {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0 && numberOfLives > 0)
            {
                SpawnPlayer();
            }
            else
            {

            }
        }
	}

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 50), "Lives: " + numberOfLives);
    }
}
