using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressWindowButton : MonoBehaviour
{
    public void StartAnimation()
    {
        gameObject.GetComponent<Animation>().Play();
    }

    public void EndAnimation()
    {
        gameObject.GetComponent<Animation>().Stop();
    }
}
