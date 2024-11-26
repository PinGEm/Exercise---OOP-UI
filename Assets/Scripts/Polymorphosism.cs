using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polymorphosism : MonoBehaviour
{
    [SerializeField] string SomeText;

    private void Start()
    {
        JustSaySomething();
    }
    public virtual void JustSaySomething() // why did i overcomplicate this
    {
        Debug.Log("Help ME");
    }
}
