using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class MyGUI : MonoBehaviour
{
    string Labeltext = "";
    string secondLabeltext = "";
    [SerializeField] Player1 player;
    [SerializeField] Player2 player2;
    [SerializeField] Player3 player3;
    private void OnGUI()
    {

        GUI.Box(new Rect(0, 0, 500, 500), "nuts");
        if (GUI.Button(new Rect(10, 10, 100, 100), "Chest"))
        {
            Debug.Log("Coin");
            Labeltext = "Coin";
        }

        if (GUI.Button(new Rect(10, 140, 100, 100), "Switch"))
        {
            Debug.Log("Door is Open");
            Labeltext = "Door is Open";
        }

        GUI.Label(new Rect(250, 100, 250, 250), Labeltext);

        GUI.Box(new Rect(1000, 0, 500, 500), "other nuts");
        if (GUI.Button(new Rect(1000, 10, 100, 100), "Player 1"))
        {
            Debug.Log("Coin");
            secondLabeltext = "player 1 stats: \n\rHealth: " + player.Health + "\n\rMana: " + player.Mana + "\n\rAttack: " + player.Attack + "\n\rDefense: " + player.Defense + "\n\rSpeed: " + player.Speed;
        }

        if (GUI.Button(new Rect(1000, 140, 100, 100), "Player 2"))
        {
            Debug.Log("Door is Open");
            secondLabeltext = "player 2 stats: \n\rHealth: " + player2.Health + "\n\rMana: " + player2.Mana + "\n\rAttack: " + player2.Attack + "\n\rDefense: " + player2.Defense + "\n\rSpeed: " + player2.Speed;
        }

        if (GUI.Button(new Rect(1000, 270, 100, 100), "Player 3"))
        {
            Debug.Log("Door is Open");
            secondLabeltext = "player 3 stats: \n\rHealth: " + player3.Health + "\n\rMana: " + player3.Mana + "\n\rAttack: " + player3.Attack + "\n\rDefense: " + player3.Defense + "\n\rSpeed: " + player3.Speed;
        }
        GUI.Label(new Rect(1250, 100, 250, 250), secondLabeltext);

    }
}
