using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleManager : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Cat;
    [SerializeField] GameObject TV;

    [SerializeField] UnityEngine.Video.VideoPlayer Out_0;
    [SerializeField] UnityEngine.Video.VideoPlayer Out_1;

    [SerializeField] GameObject[] Slots;
    [SerializeField] GameObject[] Objects;
    [SerializeField] Text wallText;

    string soundBG;
    float slider;

    string player;
    string invent;

    string language;
    

    void Start()
    {
        //Звук из настроек меню
        AudioSource audioBG = gameObject.GetComponent<AudioSource>();
        soundBG = PlayerPrefs.GetString("BG", "true");
        slider = PlayerPrefs.GetFloat("Slider",1);
        AudioListener.volume = slider;
        if (soundBG == "false") audioBG.Stop();

        //Положение игрока и инвентарь
        player = PlayerPrefs.GetString("player","5 -26 0");
        invent = PlayerPrefs.GetString("invent","00000");
        
        for (int i = 0; i < 5; i++)
            if (invent[i] == '1')
            {
                Slots[i].SetActive(true);
                Objects[i].SetActive(false);
            }
        
        string[] words = player.Split(new char[] { ' ' });

        Player.transform.position = new Vector3(float.Parse(words[0]), -0.05f, float.Parse(words[1]));
        Player.transform.rotation = Quaternion.Euler(0, float.Parse(words[2]), 0);

        //Локализация
        language = PlayerPrefs.GetString("local", "eng");

        if(language == "eng")
        {
            wallText.text = "The chamber of secrets has been opened. Enemies of the heir... Beware.";
        }
        else
        {
            wallText.text = "Тайная комната снова открыта. Трепещите враги наследника.";
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
}
