using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public Text text1;
    public void SetSound()
    {
        switch (text1.text)
        {
            case "ClickSound On":
                text1.text = "ClickSound Off";
                PlayerPrefs.SetString("Click", "false");
                break;
            case "ClickSound Off":
                text1.text = "ClickSound On";
                PlayerPrefs.SetString("Click", "true");
                break;
            case "BackSound On":
                text1.text = "BackSound Off";
                PlayerPrefs.SetString("BG", "false");
                break;
            case "BackSound Off":
                text1.text = "BackSound On";
                PlayerPrefs.SetString("BG", "true");
                break;
        }
    }
}
