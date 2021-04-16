using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TakeObject : MonoBehaviour, IInteractable
{
    public Sprite item;
    public GameObject itemPanel;

    public void Interact()
    {
        Take();
    }
    void Take()
    {
        itemPanel.SetActive(true);
        Destroy(gameObject);
    }
}
