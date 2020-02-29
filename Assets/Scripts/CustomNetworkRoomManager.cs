using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class CustomNetworkRoomManager : NetworkRoomManager
{
    public ScrollView lobbyPlayers;

    public override void OnGUI()
    {
        if (SceneManager.GetActiveScene().name == RoomScene)
        {
            Debug.Log("Ass");
        }
    }
}

