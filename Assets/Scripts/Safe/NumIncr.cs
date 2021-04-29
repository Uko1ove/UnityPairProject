using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumIncr : MonoBehaviour, IInteractable
{
    public Text text1;

    public void Interact()
    {
        if (text1.text == "9") text1.text = "0";
        else
        {
            int i = int.Parse(text1.text) + 1;
            text1.text = $"{i++}";
        }
    }
}
