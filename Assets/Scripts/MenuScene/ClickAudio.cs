using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAudio : MonoBehaviour
{
    [SerializeField] Text textButton;
    public AudioSource audio1;
    public AudioSource audio2;
    

    public void Click()
    {
        string text = PlayerPrefs.GetString("Click","true");
        if (text == "true") audio1.Play();

        if (textButton != null)
        {
            switch (textButton.text)
            {
                case "ClickSound On":
                    textButton.text = "ClickSound Off";
                    PlayerPrefs.SetString("Click", "false");
                    break;
                case "ClickSound Off":
                    textButton.text = "ClickSound On";
                    PlayerPrefs.SetString("Click", "true");
                    break;
                case "BackSound On":
                    textButton.text = "BackSound Off";
                    PlayerPrefs.SetString("BG", "false");
                    break;
                case "BackSound Off":
                    textButton.text = "BackSound On";
                    PlayerPrefs.SetString("BG", "true");
                    break;
            }
        }
    }

    public void BG()
    {
        string text = PlayerPrefs.GetString("BG", "true");
        if (text == "true") audio2.Play();
        else audio2.Stop();
    }
}
