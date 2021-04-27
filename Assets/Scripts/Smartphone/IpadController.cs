using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IpadController : MonoBehaviour 
{
    GameObject player;
    [SerializeField] GameObject screenOff;
    [SerializeField] GameObject screenOnLocked;
    [SerializeField] GameObject slider;

    private float sliderValue;
    private bool isScreenBlocked;
    

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

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("player");
        isScreenBlocked = player.GetComponent<PlayerController>().IsScreenBlocked;
        sliderValue = slider.GetComponent<Slider>().value;
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
