using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster instance; // player

    private void Awake()
    {
        instance = this;
    }

    public PlayerManager playerManager;
    

}
