using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseLightControllerSingle : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject houseLight;
    private bool isLightActive = false;
    private Animator anim;

    public void Interact()
    {
        anim = GetComponent<Animator>();
        if(anim.enabled == false)
        {
            anim = GetComponent<Animator>();
            anim.enabled = true;
            Invoke("Stop", 0.5f);
            houseLight.SetActive(!isLightActive);
            isLightActive = !isLightActive;
        }
    }

    private void Stop()
    {
        anim.enabled = false;
    }
}
