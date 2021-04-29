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
        ContinueButton.text = "Продолжить";
        NewGameButton.text = "Новая игра";
        CoopButton.text = "Сеть";
        ServerButton.text = "Сервер";
        ClientButton.text = "Клиент";
        SettingsMenuButton.text = "Настройки";
        ExitButton.text = "Выход";

        LanguageButton.text = "Язык";
        EngButton.text = "Английский";
        RusButton.text = "Русский";
        BackLangButton.text = "Назад";

        SoundButton.text = "Звук";
        BGButton.text = "Фон";
        ClickButton.text = "Клик";
        BackSoundButton.text = "Назад";

        ResetButton.text = "Сброс прогресса";
        YesButton.text = "Да";
        NoButton.text = "Нет";

        BackSettingsButton.text = "Назад";

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
