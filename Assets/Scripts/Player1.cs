using Stats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player1 : PlayerStats, DamageCalc
{
    Player2 playertwo;
    private void Start()
    {
        sayHi();
        dmgCalc(15);
    }
    public override void sayHi()
    {
        Debug.Log("Player 1 has said Hi");
    }

    public void dmgCalc(int dmg)
    {
        Debug.Log("Player One Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Player One HP: " + Health);
    }
}
