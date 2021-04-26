using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IpadController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject screenOff;
    [SerializeField] GameObject screenOnLocked;
    [SerializeField] GameObject slider;

    private float sliderValue;
    private bool isScreenBlocked;
    private bool isIpadLocked;

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

    }

    private void Update()
    {
        isScreenBlocked = player.GetComponent<PlayerController>().IsScreenBlocked;
        screenOff.SetActive(isScreenBlocked);
        sliderValue = slider.GetComponent<Slider>().value;
        isIpadLocked = player.GetComponent<PlayerController>().IsScreenLocked;

        if (isScreenBlocked == false)
        {
            if (sliderValue >= 0.85)
            {
                screenOnLocked.SetActive(false);
            }
            else
            {
                screenOnLocked.SetActive(true);
            }
        }

        if (isIpadLocked == true)
        {
            screenOnLocked.SetActive(isIpadLocked);
            slider.GetComponent<Slider>().value = 0;
        }
    }
}
