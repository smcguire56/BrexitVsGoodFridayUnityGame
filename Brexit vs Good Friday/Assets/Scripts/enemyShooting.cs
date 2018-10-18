using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public Vector3 bulletoffset = new Vector3(0, 1.7f, 0);
    public float fireDelay = 0.5f;
    float coolDownTimer = 0;

    void Update()
    {
        coolDownTimer -= Time.deltaTime;

        if (coolDownTimer <= 0)
        {
            coolDownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletoffset;

            GameObject bulletGO =(GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = gameObject.layer;

        }
    }
}
