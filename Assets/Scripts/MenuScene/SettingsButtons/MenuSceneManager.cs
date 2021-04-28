using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneManager : MonoBehaviour
{
    public GameObject ContinueButton;
    private void Start()
    {
        string player = PlayerPrefs.GetString("player");
        string invent = PlayerPrefs.GetString("invent");

        if (player == "5 -26 0" && invent == "00000") try { ContinueButton.SetActive(false); } catch { };
    }
}
