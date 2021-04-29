using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoopManager : MonoBehaviourPunCallbacks
{
    GameObject Player;
    [SerializeField] GameObject Cat;
    [SerializeField] GameObject TV;

    [SerializeField] UnityEngine.Video.VideoPlayer Out_0;
    [SerializeField] UnityEngine.Video.VideoPlayer Out_1;

    public GameObject PlayerPref;
    public GameObject Panel;
    GameObject action;

    [SerializeField] Text WallText;
    [SerializeField] Text ReturnText;
    [SerializeField] Text ExitText;
    [SerializeField] Text DiscriptText;

    string soundBG;
    float slider;

    string language;

    void Awake()
    {
        PhotonNetwork.Instantiate(PlayerPref.name, new Vector3(5,-0.05f,-26), Quaternion.identity );
    }

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("player");

        //Звук из настроек меню
        AudioSource audioBG = gameObject.GetComponent<AudioSource>();
        soundBG = PlayerPrefs.GetString("BG", "true");
        slider = PlayerPrefs.GetFloat("Slider", 1);
        AudioListener.volume = slider;
        if (soundBG == "false") audioBG.Stop();

        //Локализация
        language = PlayerPrefs.GetString("local", "eng");

        if (language == "eng")
        {
            WallText.text = "The chamber of secrets has been opened. Enemies of the heir... Beware.";
            ReturnText.text = "Return";
            ExitText.text = "Exit";
            DiscriptText.text = "Mouse LClick - Use\nLCtr - Unlock Ipad\nLAlt - Take / Put Ipad";
        }
        else
        {
            WallText.text = "Тайная комната снова открыта. Трепещите враги наследника.";
            ReturnText.text = "Вернуться";
            ExitText.text = "Выход";
            DiscriptText.text = "Mouse LClick - Использ\nLCtr - Разблок Ipad\nLAlt - Взять/Полож Ipad";
        }
    }

    private void Update()
    {
        float Player_x = Player.transform.position.x;
        float Cat_x = Cat.transform.position.x;
        float TV_x = TV.transform.position.x;

        float Player_z = Player.transform.position.z;
        float Cat_z = Cat.transform.position.z;
        float TV_z = TV.transform.position.z;

        float func = Mathf.Sqrt(Mathf.Pow((Player.transform.position.x - Cat.transform.position.x), 2) +
                                Mathf.Pow((Player.transform.position.z - Cat.transform.position.z), 2));
        func = 0.2f - 0.2f * func / 80;

        if (func > 0)
            Cat.GetComponent<AudioSource>().volume = func;
        else Cat.GetComponent<AudioSource>().volume = 0;

        func = Mathf.Sqrt(Mathf.Pow((Player.transform.position.x - TV.transform.position.x), 2) +
                          Mathf.Pow((Player.transform.position.z - TV.transform.position.z), 2));
        func = 1f - 1f * func / 80;

        if (func > 0)
        {
            Out_0.SetDirectAudioVolume(0, func);
            Out_1.SetDirectAudioVolume(0, func);
        }
        else
        {
            Out_0.SetDirectAudioVolume(0, 0);
            Out_1.SetDirectAudioVolume(0, 0);
        }
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