using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSceneManager : MonoBehaviour
{
    public GameObject ContinueButton;
    [SerializeField] Text continueText;

    string language;

    private void Start()
    {
        string player = PlayerPrefs.GetString("player");
        string invent = PlayerPrefs.GetString("invent");

        if (player == "5 -26 0" && invent == "00000") try { ContinueButton.SetActive(false); } catch { };

        language = PlayerPrefs.GetString("local", "eng");

        if (language == "eng")
        {
            continueText.text = "Continue";
        }
        else
        {
            continueText.text = "Продолжить";
        }
    }
}
