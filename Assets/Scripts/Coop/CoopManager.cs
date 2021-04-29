using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoopManager : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPref;
    public GameObject Panel;
    GameObject action;
    [SerializeField] Text wallText;

    string soundBG;
    float slider;

    string language;

    void Awake()
    {
        PhotonNetwork.Instantiate(PlayerPref.name, new Vector3(5,-0.05f,-26), Quaternion.identity );
    }

    private void Start()
    {
        //���� �� �������� ����
        AudioSource audioBG = gameObject.GetComponent<AudioSource>();
        soundBG = PlayerPrefs.GetString("BG", "true");
        slider = PlayerPrefs.GetFloat("Slider", 1);
        AudioListener.volume = slider;
        if (soundBG == "false") audioBG.Stop();

        //�����������
        language = PlayerPrefs.GetString("local", "eng");

        if (language == "eng")
        {
            wallText.text = "The chamber of secrets has been opened. Enemies of the heir... Beware.";
        }
        else
        {
            wallText.text = "������ ������� ����� �������. ��������� ����� ����������.";
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
        //����� ������� ����� (��) �������� �������
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