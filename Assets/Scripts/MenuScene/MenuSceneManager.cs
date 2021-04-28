using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSceneManager : MonoBehaviour
{
    [SerializeField] AudioSource audioBG;
    public GameObject ContinueButton;
    [SerializeField] GameObject Slider;

    [SerializeField] Text continueText;
    [SerializeField] Text newGameText;
    [SerializeField] Text coopText;
    [SerializeField] Text serverText;
    [SerializeField] Text clientText;
    [SerializeField] Text settingsText;
    [SerializeField] Text exitText;
    [SerializeField] Text languageText;
    [SerializeField] Text engText;
    [SerializeField] Text rusText;
    [SerializeField] Text backLanguageText;
    [SerializeField] Text soundText;
    [SerializeField] Text bgSoundText;
    [SerializeField] Text clickSoundText;
    [SerializeField] Text backSoundText;
    [SerializeField] Text resetText;
    [SerializeField] Text yesText;
    [SerializeField] Text noText;
    [SerializeField] Text backSettingsText;

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

        if (player == "5 -26 0" && invent == "00000") try { ContinueButton.SetActive(false); } catch { };

        //�������� �����������
        language = PlayerPrefs.GetString("local", "eng");

        if (language == "eng")
        {
            continueText.text = "Continue";
            newGameText.text = "New Game";
            coopText.text = "Coop";
            serverText.text = "Server";
            clientText.text = "Client";
            settingsText.text = "Settings";
            exitText.text = "Exit";

            languageText.text = "Language";
            engText.text = "English";
            rusText.text = "Russian";
            backLanguageText.text = "Back";

            soundText.text = "Sound";
            bgSoundText.text = "BackSound";
            clickSoundText.text = "ClickSound";
            backSoundText.text = "Back";

            resetText.text = "Reset Progress";
            yesText.text = "Yes";
            noText.text = "No";
            backSettingsText.text = "Back";
        }
        else
        {
            continueText.text = "����������";
            newGameText.text = "����� ����";
            coopText.text = "����";
            serverText.text = "������";
            clientText.text = "������";
            settingsText.text = "���������";
            exitText.text = "�����";

            languageText.text = "����";
            engText.text = "����������";
            rusText.text = "�������";
            backLanguageText.text = "�����";

            soundText.text = "����";
            bgSoundText.text = "���";
            clickSoundText.text = "����";
            backSoundText.text = "�����";

            resetText.text = "����� ���������";
            yesText.text = "��";
            noText.text = "���";
            backSettingsText.text = "�����";
        }
    }
}
