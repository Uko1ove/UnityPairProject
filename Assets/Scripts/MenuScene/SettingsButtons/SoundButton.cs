using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] GameObject settingsMenu;
    [SerializeField] GameObject soundMenu;

    public void SoundSetting()
    {
        settingsMenu.SetActive(!settingsMenu.activeSelf);
        soundMenu.SetActive(!soundMenu.activeSelf);
    }
}
