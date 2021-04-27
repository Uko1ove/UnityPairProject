using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageButton : MonoBehaviour
{
    [SerializeField] GameObject settingsMenu;
    [SerializeField] GameObject languageMenu;

    public void ToggleLanguageMenu()
    {
        settingsMenu.SetActive(!settingsMenu.activeSelf);
        languageMenu.SetActive(!languageMenu.activeSelf);
    }
}
