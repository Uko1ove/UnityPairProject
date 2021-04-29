using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class HouseLightController : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject houseLight;
    private bool isLightActive = false;
    PhotonView photonView;
    private Animator anim;

    public void Interact()
    {
        anim = GetComponent<Animator>();
        if(anim.enabled == false)
        {
            photonView = GetComponent<PhotonView>();
            photonView.RPC("Open", RpcTarget.All);
        }
    }

    [PunRPC]
    private void Open()
    {
        anim = GetComponent<Animator>();
        anim.enabled = true;
        Invoke("Stop", 0.5f);
        houseLight.SetActive(!isLightActive);
        isLightActive = !isLightActive;
    }

    private void Stop()
    {
        anim.enabled = false;
    }
}
