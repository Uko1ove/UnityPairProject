using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeftGameCoop : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPref;
    public GameObject Panel;
    GameObject action;
    [SerializeField] Text wallText;

    string eng;
    string rus;
    string language;

    void Awake()
    {
        PhotonNetwork.Instantiate(PlayerPref.name, new Vector3(-22,0,1), Quaternion.identity );
    }

    private void Start()
    {
        eng = "The chamber of secrets has been opened. Enemies of the heir... Beware.";
        rus = "“айна€ комната снова открыта. “репещите враги наследника.";
        language = PlayerPrefs.GetString("local", "eng");

        if (language == "eng")
        {
            wallText.text = eng;
        }
        else
        {
            wallText.text = rus;
        }
    }

    void Update()
    {

    }

    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        //когда текущий игрок (ты) покидает комнату
        SceneManager.LoadScene(0);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName + " entered room");
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log(otherPlayer.NickName + " left room");
    }
}