using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.SceneManagement;

public class CustomNetworkRoomPlayer : NetworkRoomPlayer
{
    public override void OnGUI()
    {
        NetworkRoomManager roomManager = NetworkManager.singleton as NetworkRoomManager;
        if(roomManager)
        {
            Debug.Log("fuck yeah");
        }
    }
}
