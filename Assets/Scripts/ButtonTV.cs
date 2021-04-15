using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTV : MonoBehaviour
{
    public GameObject videoPlayer_0;
    public GameObject videoSource_0;
    public GameObject videoPlayer_1;
    public GameObject videoSource_1;
    public GameObject go1;
    private bool remote = false;
    private Animator anim1;

    public void Play()
    {
        anim1 = GetComponent<Animator>();
        anim1.enabled = true;

        if (go1.activeInHierarchy == true) remote = true;
        //сделать кнопку вкл ТВ меньше в продакшэне
        //получение в bool наличия пульта

        Invoke("VideoPlay", 1);
    }

    void VideoPlay()
    {
        anim1.enabled = false;

        switch (remote) //тут будет условие наличия пульта
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
