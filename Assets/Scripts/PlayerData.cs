using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {

    public int coins;
    public float secondsLeft;

    public PlayerData(CharacterController player)
    {
        coins = player.coins;
        secondsLeft = player.secondsLeft;
    }
}
