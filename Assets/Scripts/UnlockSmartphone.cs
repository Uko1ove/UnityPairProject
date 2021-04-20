using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockSmartphone : MonoBehaviour
{
    [SerializeField] GameObject slider;
    
    void Update()
    {
        if(slider.GetComponent<Slider>().value >= 0.85f)
        {
            gameObject.SetActive(false);
        }
    }
}
