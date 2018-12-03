using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerSpawner : MonoBehaviour {

    public GameObject playerPrefab;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject gameOverUI;

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

        if (numberOfLives > 4)
        {
            numberOfLives = 4;
        }

        switch (numberOfLives)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
        }
        
    }
    // Update is called once per frame
    void Update () {
        if (playerInstance == null) {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0 && numberOfLives > 0)
            {
                SpawnPlayer();
            }
        }
        if (numberOfLives == 0)
        {

            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            gameOverUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
