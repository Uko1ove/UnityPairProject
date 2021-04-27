using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class LeftGameCoop : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPref;
    GameObject action;

    void Awake()
    {
        PhotonNetwork.Instantiate(PlayerPref.name, new Vector3(-22,0,1), Quaternion.identity );
    }

    void Update()
    {

    }

    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        //когда текущий игрок (ты) покидает комнату
        SceneManager.LoadScene(0);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName + " entered room");
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log(otherPlayer.NickName + " left room");
    }
}