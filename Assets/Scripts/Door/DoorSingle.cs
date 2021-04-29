using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorSingle : MonoBehaviour, IInteractable
{
    public GameObject HandleRotate;
    public GameObject FullDoor;

    public AudioSource audioHandle;
    public AudioSource audioClose;
    public AudioSource audioOpen;

    public GameObject Key;
    public GameObject Crystal_1;
    public GameObject Crystal_2;

    Animator anim1;
    Animator anim2;
    bool trigger;

    public void Interact()
    {
        anim1 = GetComponent<Animator>();
        anim2 = HandleRotate.GetComponent<Animator>();

        if (anim1.enabled == false && anim2.enabled == false)
        {
            Open();
        }
    }

    void Open()
    {
        anim1 = GetComponent<Animator>();
        anim2 = HandleRotate.GetComponent<Animator>();

        trigger = false;
        switch (FullDoor.tag)
        {
            case "final_door":
                if (Key.activeInHierarchy == true &&
                    Crystal_1.activeInHierarchy == true &&
                    Crystal_2.activeInHierarchy == true) trigger = true;
                break;
            case "simple_door":
                trigger = true;
                break;
        }
        if (trigger)
        {
            anim1.enabled = true;

            float fdtrey = FullDoor.transform.rotation.eulerAngles.y;
            float trey = transform.rotation.eulerAngles.y;

            if ( trey < fdtrey + 1 && trey > fdtrey - 1)
                audioOpen.Play();
            else audioClose.Play();
        }
        else
        {
            anim2.enabled = true;
            audioHandle.Play();
        }

        Invoke("Stop", 2.01f);
    }

    void Stop()
    {
        if (trigger)
            anim1.enabled = false;
        else anim2.enabled = false;
    }
}
