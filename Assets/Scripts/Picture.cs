using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        SwipePicture();
    }

    void SwipePicture()
    {
        Animator anim1 = GetComponent<Animator>();
        anim1.enabled = true;
    }
}
