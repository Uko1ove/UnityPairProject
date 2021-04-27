using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyScript : MonoBehaviourPunCallbacks
{

    void Start()
    {
        PhotonNetwork.NickName = "Player" + Random.Range(0,2);
        Debug.Log("Player's name is set to " + PhotonNetwork.NickName);

        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Server");
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions { MaxPlayers = 2 });
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined the room");
        PhotonNetwork.LoadLevel("GameNetwork");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }
}
