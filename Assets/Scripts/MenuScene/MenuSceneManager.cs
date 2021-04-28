using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSceneManager : MonoBehaviour
{
    public GameObject ContinueButton;
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
        string player = PlayerPrefs.GetString("player");
        string invent = PlayerPrefs.GetString("invent");

        if (player == "5 -26 0" && invent == "00000") try { ContinueButton.SetActive(false); } catch { };

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
            bgSoundText.text = "BackSound On";
            clickSoundText.text = "ClickSound On";
            backSoundText.text = "Back";

            resetText.text = "Reset Progress";
            yesText.text = "Yes";
            noText.text = "No";
            backSettingsText.text = "Back";
        }
        else
        {
            continueText.text = "Продолжить";
            newGameText.text = "Новая игра";
            coopText.text = "Сеть";
            serverText.text = "Сервер";
            clientText.text = "Клиент";
            settingsText.text = "Настройки";
            exitText.text = "Выход";

            languageText.text = "Язык";
            engText.text = "Английский";
            rusText.text = "Русский";
            backLanguageText.text = "Назад";

            soundText.text = "Звук";
            bgSoundText.text = "Фон";
            clickSoundText.text = "Клик";
            backSoundText.text = "Назад";

            resetText.text = "Сброс прогресса";
            yesText.text = "Да";
            noText.text = "Нет";
            backSettingsText.text = "Назад";
        }
    }
}
