using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTVSingle : MonoBehaviour
{
    public GameObject videoPlayer_0;
    public GameObject videoSource_0;
    public GameObject ControllerTV;
    private bool remote = false;

    private void Update()
    {
        if (ControllerTV.activeInHierarchy == true) remote = true;
        if (remote != false)
        {
            videoPlayer_0.SetActive(false);
            videoSource_0.SetActive(false);
        }
    }
}
