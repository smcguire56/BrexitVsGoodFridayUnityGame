using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageEnemy : MonoBehaviour
{
    public int health = 1;
    static protected int kills = 0;
    public int requiredKills = 5;

    // enemy health follower
    void OnTriggerEnter2D()
    {
        health--;
    }

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        kills++;

        // load next scene after getting the required amount of kills
        if (kills >= requiredKills && SceneManager.GetActiveScene().name.Equals("SampleScene"))
        {
            SceneManager.LoadScene(4);
            kills = 0;

        }

        if (kills >= requiredKills && SceneManager.GetActiveScene().name.Equals("Chapter2"))
        {
            SceneManager.LoadScene(5);
            kills = 0;

        }

        if (kills >= requiredKills && SceneManager.GetActiveScene().name.Equals("Chapter3"))
        {
            SceneManager.LoadScene(6);
            kills = 0;

        }
    }
}
