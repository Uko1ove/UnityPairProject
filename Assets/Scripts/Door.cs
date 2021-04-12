using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public GameObject HandleRotate;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    Animator anim1;
    Animator anim2;
    Button but1;

    public void Open()
    {
        if (true)
        {
            anim1 = GetComponent<Animator>();
            anim1.enabled = true;
            but1 = GetComponent<Button>();
            but1.enabled = false;
            float trey = transform.rotation.eulerAngles.y;
            if ( trey < 181 && transform.rotation.eulerAngles.y > 179)
                audio2.Play();
            else audio3.Play();
        }
        else
        {
            anim2 = HandleRotate.GetComponent<Animator>();
            anim2.enabled = true;
            audio1.Play();
        }

        Invoke("Stop", 2.01f);
    }
    void Stop()
    {
        //anim2.enabled = false;
        anim1.enabled = false;
        but1.enabled = true;
    }
}
