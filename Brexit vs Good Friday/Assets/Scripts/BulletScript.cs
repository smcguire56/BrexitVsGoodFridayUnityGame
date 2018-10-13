using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float fireDelay = 0.25f;
    float coolDownTimer = 0;

	void Update () {
        coolDownTimer -= Time.deltaTime;
        
        if( Input.GetButton("Fire1") && coolDownTimer <= 0)
        {
            coolDownTimer = fireDelay;
            Debug.Log("Pew!");
        }
    }
	
}
