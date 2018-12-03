using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    private float timeLeft = 300.0f;

    public Text text;

	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        text.text = "" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            //Debug.Log("gameOver");
        }
    }
}
