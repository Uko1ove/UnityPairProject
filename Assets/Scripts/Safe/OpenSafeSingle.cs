using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSafeSingle : MonoBehaviour, IInteractable
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

        if (anim1.enabled == false)

            //исправить на 1482
            if (num1.text == "1" && num2.text == "0" && num3.text == "0" && num4.text == "0")
            {
                anim1.enabled = true;
                audio1.Play();
            }
    }
}
