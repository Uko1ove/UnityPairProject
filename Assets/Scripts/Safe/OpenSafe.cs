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
    void Update()
    {
        if (num1.text == "1" && num2.text == "0" && num3.text == "0" && num4.text == "0")
        {
            Animator anim = GetComponent<Animator>();
            anim.enabled = true;
        }


    }
}
