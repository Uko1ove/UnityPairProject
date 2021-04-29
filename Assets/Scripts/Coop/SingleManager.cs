using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleManager : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Player;
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

}
