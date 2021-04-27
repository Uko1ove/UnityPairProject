using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class Picture : MonoBehaviour, IInteractable
{
    public GameObject crystal;
    PhotonView photonView;
    
    public void Interact()
    {
        if (crystal.activeInHierarchy == true) 
        {
            photonView = GetComponent<PhotonView>();
            photonView.RPC("SwipePicture", RpcTarget.All);
        }
    }

    [PunRPC]
    void SwipePicture()
    {
        Animator anim1 = GetComponent<Animator>();
        anim1.enabled = true;
    }
}
