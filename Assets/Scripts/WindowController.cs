using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{
    private Animation animat;
    private bool isOpened = false;

    public bool IsOpened
    {
        get => isOpened;
    }

    private void Start()
    {
        animat = gameObject.GetComponent<Animation>();
    }

    public void ToggleWindow()
    {
        if(IsOpened == false)
        {
            OpenWindow(animat, "OpenRightWindow");
            OpenWindow(animat, "OpenLeftWindow");
            isOpened = true;
        }
        else
        {
            CloseWindow(animat, "CloseRightWindow");
            CloseWindow(animat, "CloseLeftWindow");
            isOpened = false;
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
