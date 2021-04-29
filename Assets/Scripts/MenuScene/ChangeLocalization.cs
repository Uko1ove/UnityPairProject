using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLocalization : MonoBehaviour
{
    [SerializeField] Text ContinueButton;
    [SerializeField] Text NewGameButton;
    [SerializeField] Text CoopButton;
        [SerializeField] Text ServerButton;
        [SerializeField] Text ClientButton;
    [SerializeField] Text SettingsMenuButton;
    [SerializeField] Text ExitButton;

    [SerializeField] Text LanguageButton;
        [SerializeField] Text EngButton;
        [SerializeField] Text RusButton;
        [SerializeField] Text BackLangButton;

    [SerializeField] Text SoundButton;
        [SerializeField] Text BGButton;
        [SerializeField] Text ClickButton;
        [SerializeField] Text BackSoundButton;

    [SerializeField] Text ResetButton;
        [SerializeField] Text YesButton;
        [SerializeField] Text NoButton;

    [SerializeField] Text BackSettingsButton;

    public void LocalizeToRus()
    {
        ContinueButton.text = "����������";
        NewGameButton.text = "����� ����";
        CoopButton.text = "����";
        ServerButton.text = "������";
        ClientButton.text = "������";
        SettingsMenuButton.text = "���������";
        ExitButton.text = "�����";

        LanguageButton.text = "����";
        EngButton.text = "����������";
        RusButton.text = "�������";
        BackLangButton.text = "�����";

        SoundButton.text = "����";
        BGButton.text = "���";
        ClickButton.text = "����";
        BackSoundButton.text = "�����";

        ResetButton.text = "����� ���������";
        YesButton.text = "��";
        NoButton.text = "���";

        BackSettingsButton.text = "�����";

        PlayerPrefs.SetString("local", "rus");
        PlayerPrefs.Save();
    }

    public void LocalizeToEng()
    {
        ContinueButton.text = "Continue";
        NewGameButton.text = "New Game";
        CoopButton.text = "Coop";
        ServerButton.text = "Server";
        ClientButton.text = "Client";
        SettingsMenuButton.text = "Settings";
        ExitButton.text = "Exit";

        LanguageButton.text = "Language";
        EngButton.text = "English";
        RusButton.text = "Russian";
        BackLangButton.text = "Back";

        SoundButton.text = "Sound";
        BGButton.text = "BackSound";
        ClickButton.text = "ClickSound";
        BackSoundButton.text = "Back";

        ResetButton.text = "Reset Progress";
        YesButton.text = "Yes";
        NoButton.text = "No";

        BackSettingsButton.text = "Back";

        PlayerPrefs.SetString("local", "eng");
        PlayerPrefs.Save();
    }
}
