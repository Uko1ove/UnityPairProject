using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public GameObject SettingMenu;
    public GameObject SoundMenu;

    public void SoundSetting()
    {
        Text text1 = GetComponentInChildren<Text>();

        if (SettingMenu.activeInHierarchy == true)
        {
            text1.text = "Back";

            SettingMenu.SetActive(false);
            SoundMenu.SetActive(true);
        }
        else
        {
            text1.text = "Sound";

            SettingMenu.SetActive(true);
            SoundMenu.SetActive(false);
        }
    }
}
