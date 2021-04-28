using System.Collections;
using Photon.Pun;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuInGame : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Player;
    public GameObject[] Slots;

    string player;
    string invent;

    public void Return()
    {
        Panel.SetActive(false);
    }

    public void Save()
    {
        float px = Player.transform.position.x;
        float pz = Player.transform.position.z;
        float ry = Player.transform.localRotation.eulerAngles.y;

        player = $"{px} {pz} {ry}";

        invent = "";

        foreach (var i in Slots)
        {
            if (i.activeInHierarchy == true)
                invent += "1";
            else invent += "0";
        }            

        PlayerPrefs.SetString("player", player);
        PlayerPrefs.SetString("invent", invent);

        PlayerPrefs.Save();

        Panel.SetActive(false);
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitCoop()
    {
        PhotonNetwork.LeaveRoom();
    }
}
