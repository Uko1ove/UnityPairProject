using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class OpenSafe : MonoBehaviour, IInteractable
{
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;

    public AudioSource audio1;
    Animator anim1;

    PhotonView photonView;

    public void Interact()
    {
        anim1 = GetComponent<Animator>();

        if (anim1.enabled == false)

            //исправить на 1482
            if (num1.text == "1" && num2.text == "0" && num3.text == "0" && num4.text == "0")
            {
                photonView = GetComponent<PhotonView>();
                photonView.RPC("Open", RpcTarget.All);
            }
    }

    [PunRPC]
    void Open()
    {
        anim1 = GetComponent<Animator>();
        anim1.enabled = true;
        audio1.Play();
    }
}
