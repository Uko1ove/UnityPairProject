using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WindowControllerSingle : MonoBehaviour, IInteractable
{
    [SerializeField]
        GameObject Window;
    Animator anim1;

    public bool isOpen { get; private set; }

    public void Interact()
    {
        anim1 = GetComponent<Animator>();
        if (anim1.enabled == false)
        {
            anim1 = GetComponent<Animator>();
            anim1.enabled = true;
            Invoke("Stop", 1.01f);
        }
    }

    void Stop()
    {
        anim1.enabled = false;
        if (Window.transform.rotation.eulerAngles.y > 45) isOpen = true;
        else isOpen = false;
    }
}
