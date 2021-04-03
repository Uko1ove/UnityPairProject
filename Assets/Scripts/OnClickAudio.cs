using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickAudio : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;

    public void Click()
    {
        string text = PlayerPrefs.GetString("Click","true");
        if (text == "true") audio1.Play();
    }
    public void BG()
    {
        string text = PlayerPrefs.GetString("BG", "true");
        if (text == "true") audio2.Play();
        else audio2.Stop();
    }
}
