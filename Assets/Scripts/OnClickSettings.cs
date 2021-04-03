using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickSettings : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    public Text text1;

    public void Settings()
    {
        if (go1.activeInHierarchy == true)
        {
            go1.SetActive(false);
            go2.SetActive(false);

            go3.SetActive(true);
            go4.SetActive(true);

        }
        else
        {
            go1.SetActive(true);
            go2.SetActive(true);

            go3.SetActive(false);
            go4.SetActive(false);
        }
    }

    public void SetSound()
    {
        switch (text1.text)
        {
            case "ClickSound On":
                text1.text = "ClickSound Off";
                PlayerPrefs.SetString("Click","false");
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
