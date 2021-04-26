using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour, IInteractable
{

    Animator anim1;
    public GameObject Window;
    bool isOpen { get; set; }

    public void Interact()
    {
        anim1 = GetComponent<Animator>();
        if (anim1.enabled == false) Open();
    }

    public void Open()
    {
        anim1.enabled = true;
        Invoke("Stop", 0.51f);
    }

    void Stop()
    {
        anim1.enabled = false;
        if (transform.rotation.eulerAngles.y > 45) isOpen = true;
        else isOpen = false;
    }
}
