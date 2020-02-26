using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;

public class CustomNetworkManagerHUD : MonoBehaviour
{
    NetworkManager networkManager;
    TelepathyTransport telepathyTransport;

    public InputField IpAddress;
    public InputField port;

    void Awake()
    {
        networkManager = GetComponent<NetworkManager>();
        telepathyTransport = GetComponent<TelepathyTransport>();
    }

    void Start()
    {
        // TODO: take input from InputField
        NetworkManager.singleton.networkAddress = "http://localhost";
        telepathyTransport.port = 3000;
    }

    public void StartHost()
    {
        if (!NetworkClient.isConnected && !NetworkServer.active)
        {
            if (!NetworkClient.active)
            {
                Debug.Log("StartHost: starting server...");
                networkManager.StartHost();
                Debug.Log("Transport shit -> "+Transport.activeTransport);
                Debug.Log("Network Address shit -> " + networkManager.networkAddress);
            }
        }
    }

    public void StopHost()
    {
        if(NetworkServer.active && NetworkClient.isConnected)
        {
            networkManager.StopHost();
        }
    }

    public void StartClient()
    {
        if(!NetworkClient.active)
        {
            networkManager.StartClient();
            // TODO: add ip
        }
    }

    // cancel connection attempts
    public void CancelConnection()
    {
        if(NetworkClient.isConnected)
        {
            networkManager.StopClient();
        }
    }
}
