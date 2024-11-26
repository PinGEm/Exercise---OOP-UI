using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stats
{
    public abstract class PlayerStats : MonoBehaviour
    {
        public int Health;
        public int Mana;
        public int Attack;
        public float Defense;
        public float Speed;

        public abstract void sayHi();
    }
}
