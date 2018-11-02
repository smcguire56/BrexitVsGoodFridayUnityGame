using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour {

    public Transform myTarget;
    public Vector3 offSet;

    // Update is called once per frame
    void Update () {

        if (myTarget != null)
        {
            myTarget = GameObject.FindGameObjectWithTag("Player").transform;

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
                //Debug.Log(e);
            }

        }

    }

}
