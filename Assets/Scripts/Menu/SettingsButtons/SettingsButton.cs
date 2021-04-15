using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    public GameObject goMain_0;
    public GameObject goMain_1;
    public GameObject goMain_2;
    public GameObject goIn_0;
    public GameObject goIn_1;
    public GameObject goIn_2;

    public void Settings()
    {
        Text text1 = GetComponentInChildren<Text>();

        if (goMain_0.activeInHierarchy == true)
        {
            text1.text = "Back";

            goMain_0.SetActive(false);
            goMain_1.SetActive(false);
            goMain_2.SetActive(false);

            goIn_0.SetActive(true);
            goIn_1.SetActive(true);
            goIn_2.SetActive(true);

        }
        else
        {
            text1.text = "Settings";

            goMain_0.SetActive(true);
            goMain_1.SetActive(true);
            goMain_2.SetActive(true);

            goIn_0.SetActive(false);
            goIn_1.SetActive(false);
            goIn_2.SetActive(false);
        }
    }
}
