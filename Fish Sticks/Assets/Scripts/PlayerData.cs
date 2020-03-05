using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData 
{
    public int level;
    public float score;
    public int stars;
    private PlayerData player;

    public PlayerData (Player player)
    {
        level = player.level;
        score = player.score;
        stars = player.starCount;
    }

    public PlayerData(PlayerData player)
    {
        this.player = player;
    }
}
