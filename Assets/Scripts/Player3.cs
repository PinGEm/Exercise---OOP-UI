using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;
public class Player3 : PlayerStats
{

    private void Start()
    {
        sayHi();
        dmgCalc(12);
    }
    public override void sayHi()
    {
        Debug.Log("Player 3 has said Hi");
    }

    public void dmgCalc(int dmg)
    {
        Debug.Log("Player Three Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Player Three HP: " + Health);
    }
}
