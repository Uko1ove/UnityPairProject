using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureSingle : MonoBehaviour, IInteractable
{
    public GameObject crystal;
    
    public void Interact()
    {
        if (crystal.activeInHierarchy == true) 
        {
            Animator anim1 = GetComponent<Animator>();
            anim1.enabled = true;
        }
    }
}
