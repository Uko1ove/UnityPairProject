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
            if (textButton.text == "ClickSound" || textButton.text == " лик")
            {
                if (text == "true")
                    PlayerPrefs.SetString("Click", "false");
                else
                    PlayerPrefs.SetString("Click", "true");
            }

            if (textButton.text == "BackSound" || textButton.text == "‘он")
            {
                text = PlayerPrefs.GetString("BG", "true");

                if (text == "true")
                {
                    PlayerPrefs.SetString("BG", "false");
                    audio2.Stop();
                }
                else
                {
                    PlayerPrefs.SetString("BG", "true");
                    audio2.Play();
                }
            }

            PlayerPrefs.Save();
        }
    }
}
