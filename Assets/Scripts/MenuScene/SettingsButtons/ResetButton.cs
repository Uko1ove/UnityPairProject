using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public GameObject SettingMenu;
    public GameObject ResetMenu;

    public void ResetGame()
    {
        SettingMenu.SetActive(!SettingMenu.activeInHierarchy);
        ResetMenu.SetActive(!ResetMenu.activeInHierarchy);
    }
}
