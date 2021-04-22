using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class LeftGameCoop : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPref;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(PlayerPref.name, new Vector3(15,0,1), Quaternion.identity );
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        //����� ������� ����� (��) �������� �������
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