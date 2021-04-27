using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine;

public class TakeObject : MonoBehaviour, IInteractable
{
    public GameObject itemPanel;
    PhotonView photonView;

    public void Interact()
    {
        photonView = GetComponent<PhotonView>();
        photonView.RPC("Take", RpcTarget.All);

    }

    [PunRPC]
    void Take()
    {
        itemPanel.SetActive(true);
        Destroy(gameObject);
    }
}
