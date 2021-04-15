using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public void SwipePicture()
    {
        Animator anim1 = GetComponent<Animator>();
        anim1.enabled = true;
    }
}
