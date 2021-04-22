using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
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

    public void ToggleWindow()
    {
        if(IsWindowOpened == false)
        {
            OpenWindow(animat, "OpenRightWindow");
            OpenWindow(animat, "OpenLeftWindow");
            IsWindowOpened = true;
        }
        else
        {
            CloseWindow(animat, "CloseRightWindow");
            CloseWindow(animat, "CloseLeftWindow");
            IsWindowOpened = false;
        }

    }

    public void OpenWindow(Animation anim, string animName)
    {
        var clip = anim.GetClip(animName);
        anim.clip = clip;
        anim.Play();
    }

    public void CloseWindow(Animation anim, string animName)
    {
        var clip = anim.GetClip(animName);
        anim.clip = clip;
        anim.Play();
    }

    public void StopAnimation()
    {
        gameObject.GetComponent<Animation>().Stop();
    }
}
