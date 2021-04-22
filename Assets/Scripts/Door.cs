using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour, IInteractable
{
    public GameObject HandleRotate;
    public GameObject FullDoor;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public GameObject Key;
    Animator anim1;
    Animator anim2;
    bool trigger;

    public void Interact()
    {
        anim1 = GetComponent<Animator>();
        anim2 = HandleRotate.GetComponent<Animator>();

        if (anim1.enabled == false && anim2.enabled == false) Open();
    }

    void Open()
    {
        trigger = false;
        switch (FullDoor.tag)
        {
            case "final_door":
                if (Key.activeInHierarchy == true) trigger = true;
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
                audio2.Play();
            else audio3.Play();
        }
        else
        {
            anim2.enabled = true;
            audio1.Play();
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
