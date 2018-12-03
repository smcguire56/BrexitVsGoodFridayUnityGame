using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : DamageEnemy {
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = kills + "/5 Kills";
    }



}