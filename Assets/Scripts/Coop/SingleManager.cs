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
        player = PlayerPrefs.GetString("player", "5 -0.05 26");
        invent = PlayerPrefs.GetString("invent", "00000");

        for (int i = 0; i < 5; i++)
            if (invent[i] == '1') Slots[i].SetActive(true);

        string[] words = player.Split(new char[] { ' ' });
        float[] xyz = new float[3];
        for (int i = 0; i < 3; i++)
            xyz[i] = float.Parse(words[i]);

        Player.transform.position = new Vector3(xyz[0], -0.05f, xyz[1]);
        Player.transform.rotation = Quaternion.Euler(0, xyz[2], 0);
    }

}
