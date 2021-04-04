using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioEvent : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public AudioSource audioBG;
    public void Awake()
    {
        string text;
        text = PlayerPrefs.GetString("Click", "false");
        if (text == "true") text1.text = "ClickSound On";
        else text1.text = "ClickSound Off";

        text = PlayerPrefs.GetString("BG", "false");
        if (text == "true") 
            { 
                text2.text = "BackSound On";
                audioBG.Play();
            }
        else text2.text = "BackSound Off";
    }
}
