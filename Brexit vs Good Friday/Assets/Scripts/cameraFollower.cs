using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour {

    public Transform myTarget;


    // Update is called once per frame
    void Update () {

        if (myTarget != null)
        {
            myTarget = GameObject.FindGameObjectWithTag("Player").transform;

            Vector3 targPos = myTarget.position;
            targPos.z = transform.position.z;
            transform.position = targPos;
        }
        else
        {
            try
            {
                myTarget = GameObject.FindGameObjectWithTag("Player").transform;

            }
            catch(Exception e)
            {
                //Debug.Log(e);
            }

        }

    }

}
