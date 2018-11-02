using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject bulletPrefabGerry;
    public GameObject bulletToggle;

    public Vector3 bulletoffset = new Vector3(0, 1.7f, 0);
    public float fireDelay = 0.25f;
    float coolDownTimer = 0;
    int toggleCounter = 1;

	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            toggleCounter++;
            if (toggleCounter % 2 == 0)
            {
                bulletToggle = bulletPrefabGerry;
            }
            else
            {
                bulletToggle = bulletPrefab;
            }
        }

        coolDownTimer -= Time.deltaTime;
        
        if( Input.GetButton("Fire1") && coolDownTimer <= 0)
        {
            coolDownTimer = fireDelay;

             Vector3 offset = transform.rotation * bulletoffset;

            Instantiate(bulletToggle, transform.position + offset, transform.rotation);
        }
    }
	
}
