using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVolume : MonoBehaviour
{
    [SerializeField] GameObject slider;

    public void SetGlobalVolume()
    {
        float globalVolume = slider.GetComponent<Slider>().value;
        AudioListener.volume = globalVolume;
    }
}
