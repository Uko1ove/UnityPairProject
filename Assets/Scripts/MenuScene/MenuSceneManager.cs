using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSceneManager : ChangeLocalization
{
    [SerializeField] AudioSource audioBG;
    public GameObject ContinueVisible;
    [SerializeField] GameObject Slider;

    string language;

    private void Awake()
    {
        //�������� �������� �����
        string text = PlayerPrefs.GetString("BG", "false");
        if (text == "true")
            audioBG.Play();

        float slider = PlayerPrefs.GetFloat("Slider", 1);
        AudioListener.volume = slider;
        Slider.GetComponent<Slider>().value = slider;

        //����������� ������ Continue
        string player = PlayerPrefs.GetString("player");
        string invent = PlayerPrefs.GetString("invent");

        if (player == "5 -26 0" && invent == "00000") try { ContinueVisible.SetActive(false); } catch { };

        //�������� �����������
        language = PlayerPrefs.GetString("local", "eng");

        if (language == "eng")
        {
            LocalizeToEng();
        }
        else
        {
            LocalizeToRus();
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
