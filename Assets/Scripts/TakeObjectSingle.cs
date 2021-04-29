using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TakeObjectSingle : MonoBehaviour, IInteractable
{
    public GameObject itemPanel;

    public void Interact()
    {
        itemPanel.SetActive(true);
        Destroy(gameObject);
    }
}
