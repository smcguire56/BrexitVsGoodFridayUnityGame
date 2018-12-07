using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    // initially get the game objects from unity
    public GameObject bulletPrefab;
    public GameObject bulletPrefabGerry;
    public GameObject bulletToggle;

    // define the bullet offset for the fire 
    public Vector3 bulletoffset = new Vector3(0, 1.8f, 0);

    // variables that I will be later using.
    public float fireDelay = 0.25f;
    float coolDownTimer = 0;
    int toggleCounter = 1;

	void Update () {
        // get the user input for the special ability
        if (Input.GetKeyDown(KeyCode.E))
        {
            // this toggles between special bullet and arrow.
            toggleCounter++;
            if (toggleCounter % 2 == 0)
            {
                bulletToggle = bulletPrefabGerry;
            }
            else
            {
                // toggle between the second bullet prefab
                bulletToggle = bulletPrefab;
            }
        }

        // Setting up the cooldown timer
        coolDownTimer -= Time.deltaTime;
        
        // get the keyboard input fire1 
        if( Input.GetButton("Fire1") && coolDownTimer <= 0)
        {
            coolDownTimer = fireDelay;
            // set the position for the bullet
            Vector3 offset = transform.rotation * bulletoffset;
            // spawn the new bullet 
            Instantiate(bulletToggle, transform.position + offset, transform.rotation);
        }
    }
	
}
