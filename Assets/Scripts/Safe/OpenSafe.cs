using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSafe : MonoBehaviour, IInteractable
{
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;

    public AudioSource audio1;
    Animator anim1;

    public void Interact()
    {
        anim1 = GetComponent<Animator>();

        if (anim1.enabled == false) Open();
    }
    public void Open()
    {
        if (num1.text == "1" && num2.text == "4" && num3.text == "8" && num4.text == "2")
        {
            anim1.enabled = true;
            audio1.Play();
        }
    }
}
