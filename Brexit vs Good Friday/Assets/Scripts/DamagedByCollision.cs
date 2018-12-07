using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedByCollision : MonoBehaviour {

    // basic health system, when another object enters the 2d space, 
    // dcrease the health of the player.
    public  int health = 1;

    void OnTriggerEnter2D() {
        health--;
    }

    void Update()
    {
        if (health <= 0)
        {
            // when health is 0, destroy the enemy
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
