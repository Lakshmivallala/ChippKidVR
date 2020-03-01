﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.SceneManagement;

public class CustomNetworkRoomPlayer : NetworkRoomPlayer
{
    private GameObject lobbyScrollViewContent;
    private bool isUIInstantiated = false;

    public GameObject playerLobbyUI;
    public override void OnGUI()
    {
        NetworkRoomManager roomManager = NetworkManager.singleton as NetworkRoomManager;
        if(roomManager)
        {
            if (SceneManager.GetActiveScene().name != roomManager.RoomScene)
                return;

            if(!isUIInstantiated)
            {
                lobbyScrollViewContent = GameObject.Find("LobbyScrollViewContent");

                GameObject playerCard = Instantiate(playerLobbyUI) as GameObject;

                if (lobbyScrollViewContent != null)
                {
                    playerCard.transform.SetParent(lobbyScrollViewContent.transform, false);
                    playerCard.transform.localPosition = new Vector3(
                        playerCard.transform.localRotation.x,
                        260 - index * 100,
                        playerCard.transform.localPosition.z);
                    isUIInstantiated = true;
                }
            } else
            {
                return;
            }

        }
    }
}
