using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedByCollision : MonoBehaviour {

    void OnTriggerEnter2D() {
        Debug.Log("Trigger!");
    }
}
