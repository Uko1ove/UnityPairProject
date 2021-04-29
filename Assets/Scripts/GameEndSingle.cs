using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameEndSingle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            SceneManager.LoadScene("Menu");
        }

        PlayerPrefs.SetString("player", "5 -26 0");
        PlayerPrefs.SetString("invent", "00000");
    }
}
