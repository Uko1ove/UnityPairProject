using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TakeObject : MonoBehaviour
{
    public Sprite item;
    public GameObject itemPanel;
    public void Take()
    {
        itemPanel.SetActive(true);
        Destroy(gameObject);
    }
}
