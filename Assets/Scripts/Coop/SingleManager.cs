using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleManager : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject[] Slots;
    [SerializeField] Text wallText;

    string player;
    string invent;
    string rus;
    string eng;
    string language;
    

    void Start()
    {
        player = PlayerPrefs.GetString("player","5 -26 0");
        invent = PlayerPrefs.GetString("invent","00000");
        
        for (int i = 0; i < 5; i++)
            if (invent[i] == '1') Slots[i].SetActive(true);
        
        string[] words = player.Split(new char[] { ' ' });

        Player.transform.position = new Vector3(float.Parse(words[0]), -0.05f, float.Parse(words[1]));
        Player.transform.rotation = Quaternion.Euler(0, float.Parse(words[2]), 0);

        eng = "The chamber of secrets has been opened. Enemies of the heir... Beware.";
        rus = "Тайная комната снова открыта. Трепещите враги наследника.";
        language = PlayerPrefs.GetString("local", "eng");

        if(language == "eng")
        {
            wallText.text = eng;
        }
        else
        {
            wallText.text = rus;
        }
    }

}
