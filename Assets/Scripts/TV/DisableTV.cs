using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class DisableTV : MonoBehaviour
{
    public GameObject videoPlayer_0;
    public GameObject videoSource_0;
    public GameObject ControllerTV;
    private bool remote = false;
    PhotonView photonView;

    private void Update()
    {
        if (ControllerTV.activeInHierarchy == true) remote = true;
        if (remote != false)
        {
            photonView = GetComponent<PhotonView>();
            photonView.RPC("Off", RpcTarget.All);
        }
    }

    [PunRPC]
    void Off()
    {
        videoPlayer_0.SetActive(false);
        videoSource_0.SetActive(false);
    }
}
