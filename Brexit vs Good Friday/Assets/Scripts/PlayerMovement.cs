using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float maxSpeed = 6f;
    public float rotSpeed = 180f;
    public float hor;
    public float ver;

    // Update is called once per frame
    void Update () {

        // get keyboard input
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        MovePlayer(hor, ver);
    }

    private void MovePlayer(float hor, float ver)
    {
        // Rotate player
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= hor * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        // Move player
        Vector3 posY = transform.position;

        Vector3 velocity = new Vector3(0, ver * maxSpeed * Time.deltaTime, 0);

        posY += rot * velocity;

        transform.position = posY;
    }
}
