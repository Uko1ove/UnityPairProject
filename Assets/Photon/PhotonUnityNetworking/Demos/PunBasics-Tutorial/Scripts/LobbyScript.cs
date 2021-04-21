using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyScript : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.NickName = "Player_" + Random.RandomRange(0,2);
        Debug.Log("Player's name is set to " + PhotonNetwork.NickName);

        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Server");
    }
}
