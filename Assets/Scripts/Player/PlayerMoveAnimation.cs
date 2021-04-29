using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMoveAnimation : MonoBehaviour
{
    private Animator anim1;
    private PhotonView photonView;

    private void Start()
    {
        anim1 = GetComponent<Animator>();
        photonView = GetComponent<PhotonView>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) )
        {
            if (photonView.IsMine)
                anim1.SetBool("isMove",true);
        }
        else
        {
            if (photonView.IsMine)
                anim1.SetBool("isMove", false);
        }
    }
}
