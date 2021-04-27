using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTVSingle : MonoBehaviour, IInteractable
{
    public GameObject videoPlayer_0;
    public GameObject videoSource_0;
    public GameObject videoPlayer_1;
    public GameObject videoSource_1;

    bool remote = false;
    public GameObject ControllerTV;
    Animator anim1;

    public void Interact()
    {
        anim1 = GetComponent<Animator>();

        if (anim1.enabled == false)
        {
            anim1 = GetComponent<Animator>();
            anim1.enabled = true;

            Invoke("VideoPlay", 2);
        }
    }

    void VideoPlay()
    {
        if (ControllerTV.activeInHierarchy == true) remote = true;
        anim1.enabled = false;

        switch (remote)
        {
            case false:
                switch (videoPlayer_0.activeInHierarchy)
                {
                    case false:
                        videoPlayer_0.SetActive(true);
                        videoSource_0.SetActive(true);
                        break;

                    case true:
                        videoPlayer_0.SetActive(false);
                        videoSource_0.SetActive(false);
                        break;
                }
                break;

            case true:
                switch (videoPlayer_1.activeInHierarchy)
                {
                    case false:
                        videoPlayer_1.SetActive(true);
                        videoSource_1.SetActive(true);
                        break;

                    case true:
                        videoPlayer_1.SetActive(false);
                        videoSource_1.SetActive(false);
                        break;
                }
                break;
        }
    }
}
