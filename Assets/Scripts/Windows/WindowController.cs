using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WindowController : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject Window;
    Animator anim1;

    public bool isOpen { get; private set; }

    public void Interact()
    {
        anim1 = gameObject.GetComponent<Animator>();
        if (anim1.enabled == false) Open();
    }

    public void Open()
    {
        anim1.enabled = true;
        Invoke("Stop", 1.01f);
    }

    void Stop()
    {
        anim1.enabled = false;
        if (Window.transform.rotation.eulerAngles.y > 45) isOpen = true;
        else isOpen = false;
    }
}
