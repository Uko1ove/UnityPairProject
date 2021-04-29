using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentVolumeControllerSingle : MonoBehaviour
{
    [SerializeField] List<GameObject> windowGlasses;
    [SerializeField] List<GameObject> glassFrames;
    
    private float volume;
    private bool isWindowOpened = false;
    private bool isWindowBroken = false;

    private void Start()
    {
        volume = gameObject.GetComponent<AudioSource>().volume;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var item in glassFrames)
        {
            if (item.GetComponent<WindowControllerSingle>().isOpen == true)
            {
                if (isWindowOpened == true)
                {
                    break;
                }

                isWindowOpened = true;
                break;
            }
            else
            {
                isWindowOpened = false;
            }
        }

        foreach(var item in windowGlasses)
        {
            if (isWindowBroken == true)
            {
                break;
            }

            if (item.GetComponent<BreakableWindow>().isBroken == true)
            {
                isWindowBroken = true;
                break;
            }
        }

        if(isWindowOpened == true || isWindowBroken == true)
        {
            volume = 0.6f;
            gameObject.GetComponent<AudioSource>().volume = volume;
        }
        else if(isWindowOpened == false && isWindowBroken == false && volume == 0.6f)
        {
            isWindowOpened = false;
            volume = 0.02f;
            gameObject.GetComponent<AudioSource>().volume = volume;
        }
    }
}
