using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public GameObject bulletPrefab;
    public Vector3 bulletoffset = new Vector3(0, 1.7f, 0);
    public float fireDelay = 0.25f;
    float coolDownTimer = 0;

	void Update () {
        coolDownTimer -= Time.deltaTime;
        
        if( Input.GetButton("Fire1") && coolDownTimer <= 0)
        {
            coolDownTimer = fireDelay;
            Debug.Log("Pew!");

             Vector3 offset = transform.rotation * bulletoffset;

            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        }
    }
	
}
