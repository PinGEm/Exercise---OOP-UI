using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogue : Polymorphosism
{
    private void Start()
    {
        JustSaySomething();
    }

    public override void JustSaySomething() // why did i overcomplicate this
    {
        Debug.Log("HELP!!!");
    }
}
