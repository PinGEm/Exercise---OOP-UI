using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;
public class Player2 : PlayerStats
{

    private void Start()
    {
        sayHi();
        dmgCalc(10);
    }
    public override void sayHi()
    {
        Debug.Log("Player 2 has said Hi");
    }

    public void dmgCalc(int dmg)
    {
        Debug.Log("Player Two Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Player Two HP: " + Health);
    }
}
