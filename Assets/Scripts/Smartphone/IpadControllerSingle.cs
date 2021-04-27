using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IpadControllerSingle : MonoBehaviour 
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject screenOff;
    [SerializeField] GameObject screenOnLocked;
    [SerializeField] GameObject slider;

    private float sliderValue;
    private bool isScreenBlocked;
    //private bool isIpadLocked;
    

    public GameObject ScreenOff
    {
        get => screenOff;
    }

    public GameObject ScreenOnLocked
    {
        get => screenOnLocked;
    }

    public GameObject Slider
    {
        get => slider;
    }

    public float SliderValue
    {
        get => sliderValue;
    }

    private void Start()
    {
        sliderValue = 0;
        isScreenBlocked = true;
    }

    private void Update()
    {
        isScreenBlocked = player.GetComponent<PlayerControllerSingle>().IsScreenBlocked;
        //screenOff.SetActive(isScreenBlocked);
        sliderValue = slider.GetComponent<Slider>().value;
        //isIpadLocked = player.GetComponent<PlayerControllerSingle>().IsScreenLocked;
        screenOff.SetActive(isScreenBlocked);

        if (sliderValue >= 0.85)
        {
            screenOnLocked.SetActive(false);
        }
        else
        {
            screenOnLocked.SetActive(true);
        }

        if (isScreenBlocked == true)
        {
            screenOnLocked.SetActive(isScreenBlocked);
            slider.GetComponent<Slider>().value = 0;
        }
    }
}
