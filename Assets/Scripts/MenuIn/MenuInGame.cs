using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuInGame : MonoBehaviour
{
    [SerializeField] GameObject Panel;

    public void Return()
    {
        Panel.SetActive(false);
    }

    public void Save()
    {

    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
}
