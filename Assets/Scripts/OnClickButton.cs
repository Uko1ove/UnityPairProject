using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OnClickButton : MonoBehaviour
{
    public void New()
    {
        SceneManager.LoadScene("NewGame");
    }
    public void Continue()
    {
        SceneManager.LoadScene("Continue");
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
