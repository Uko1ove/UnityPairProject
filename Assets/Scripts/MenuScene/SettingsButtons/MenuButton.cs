using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] GameObject ContinueButton;
    public void NewGame()
    {
        ResetProgress();
        SceneManager.LoadScene("GameSingle");
    }
    public void ContinueGame()
    {
        SceneManager.LoadScene("GameSingle");
    }

    public void Return()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void ResetProgress()
    {
        PlayerPrefs.SetString("player", "5 -26 0");
        PlayerPrefs.SetString("invent", "00000");
        PlayerPrefs.Save();

        try { ContinueButton.SetActive(false); } catch { }
    }
}
