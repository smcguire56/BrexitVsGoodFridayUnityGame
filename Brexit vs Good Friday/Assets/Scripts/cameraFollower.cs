using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour {
    // get the initial gameobjects from unity
    public Transform myTarget;
    public Vector3 offSet;

    // Update is called once per frame
    void Update () {
        // set the time to normal just in case its set to 0.
        Time.timeScale = 1f;

        // do a check if gerry exists in game or not
        if (myTarget != null)
        {
            // creates a camera for the game to follow 
            myTarget = GameObject.FindGameObjectWithTag("Player").transform;

            // apply the offset for the position
            Vector3 targPos = myTarget.position + offSet;
            targPos.z = transform.position.z;
            transform.position = targPos;
        }
        else
        {
            try
            {
                myTarget = GameObject.FindGameObjectWithTag("Player").transform;

            }
            catch(Exception)
            {

            }

        }

    }

}
