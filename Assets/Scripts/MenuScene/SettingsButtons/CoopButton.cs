using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoopButton : MonoBehaviour
{
    public GameObject Server;
    public GameObject Client;

    public void Coop()
    {
        if (Server.activeInHierarchy == false)
        {
            Server.SetActive(true);
            Client.SetActive(true);
        }
        else
        {
            Server.SetActive(false);
            Client.SetActive(false);
        }
    }
}
