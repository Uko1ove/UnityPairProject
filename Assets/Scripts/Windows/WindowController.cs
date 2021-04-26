using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour, IInteractable
{
    private Animation animat;

    public bool IsWindowOpened
    {
        get; private set;
    }

    private void Start()
    {
        animat = gameObject.GetComponent<Animation>();
        IsWindowOpened = false;
    }

    public void OpenWindows(Animation anim, string animName)
    {
        var clip = anim.GetClip(animName);
        anim.clip = clip;
        anim.Play();
    }

    public void CloseWindows(Animation anim, string animName)
    {
        var clip = anim.GetClip(animName);
        anim.clip = clip;
        anim.Play();
    }

    public void Interact()
    {
        if (IsWindowOpened == false)
        {
            OpenWindows(animat, "OpenWindows");
            IsWindowOpened = true;
        }
        else
        {
            CloseWindows(animat, "CloseWindows");
            IsWindowOpened = false;
        }
    }
}
