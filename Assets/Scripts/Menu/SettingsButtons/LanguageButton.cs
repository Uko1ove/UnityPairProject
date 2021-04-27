using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageButton : MonoBehaviour
{
    [SerializeField] GameObject settingsMenu;
    [SerializeField] GameObject languageMenu;
    /*public GameObject goOut_0;
    public GameObject goOut_1;
    public GameObject goOut_2;

    public GameObject goIn_0;
    public GameObject goIn_1;*/

    public void ToggleLanguageMenu()
    {
        settingsMenu.SetActive(!settingsMenu.activeSelf);
        languageMenu.SetActive(!languageMenu.activeSelf);
        /*Text text1 = GetComponentInChildren<Text>();

        if (goOut_0.activeInHierarchy == true)
        {
            text1.text = "Back";

            goOut_0.SetActive(false);
            goOut_1.SetActive(false);
            goOut_2.SetActive(false);

            goIn_0.SetActive(true);
            goIn_1.SetActive(true);
        }
        else
        {
            text1.text = "Language";

            goOut_0.SetActive(true);
            goOut_1.SetActive(true);
            goOut_2.SetActive(true);

            goIn_0.SetActive(false);
            goIn_1.SetActive(false);
        }*/
    }
}
