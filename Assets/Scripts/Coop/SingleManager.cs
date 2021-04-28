using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleManager : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject[] Slots;

    string player;
    string invent;

    void Start()
    {
        player = PlayerPrefs.GetString("player","5 -26 0");
        invent = PlayerPrefs.GetString("invent","00000");
        
        for (int i = 0; i < 5; i++)
            if (invent[i] == '1') Slots[i].SetActive(true);
        
        string[] words = player.Split(new char[] { ' ' });

        Player.transform.position = new Vector3(float.Parse(words[0]), -0.05f, float.Parse(words[1]));
        Player.transform.rotation = Quaternion.Euler(0, float.Parse(words[2]), 0);
    }

}
