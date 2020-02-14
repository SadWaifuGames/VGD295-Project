using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData 
{
    public int level;
    public float score;
    public int stars;

    public PlayerData (GameMaster gameMaster)
    {
        level = gameMaster.levelCount;
        score = gameMaster.playerScore;
        stars = gameMaster.starCount;
    }
}
