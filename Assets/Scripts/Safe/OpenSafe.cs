using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSafe : MonoBehaviour
{
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
    public AudioSource audio1;
    public GameObject HandleRotate;

    public void Open()
    {
        if (num1.text == "1" && num2.text == "0" && num3.text == "0" && num4.text == "0")
        {
            Animator anim1 = GetComponent<Animator>();
            anim1.enabled = true;

            Animator anim2 = HandleRotate.GetComponent<Animator>();
            anim2.enabled = true;

            audio1.Play();
}


    }
}
