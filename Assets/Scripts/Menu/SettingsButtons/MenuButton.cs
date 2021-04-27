using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public void New()
    {
        SceneManager.LoadScene("GameSingle");
    }
    public void Continue()
    {
        // загрузка из Pref
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
}
