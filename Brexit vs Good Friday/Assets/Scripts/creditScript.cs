using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditScript : MonoBehaviour {
    private float time = 0f;
    private float delay = 16f;

	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        // after the credits role, load up the main menu again.
        if(time > delay)
            SceneManager.LoadScene(0);
	}
}
