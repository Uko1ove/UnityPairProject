using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveAnimation : MonoBehaviour
{
    private Animator anim1;

    private void Start()
    {
        anim1 = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) )
        {
            anim1.SetBool("isMove",true);
        }
        else
        {
            anim1.SetBool("isMove", false);
        }
    }
}
