using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalTimeText : MonoBehaviour, ITime
{
    public void ApplyNewTime(int seconds, int minutes, int hours)
    {
        if(minutes < 9)
        {
            if(hours < 9)
            {
                gameObject.GetComponent<Text>().text = $"0{hours}:0{minutes}";
            }
            else
            {
                gameObject.GetComponent<Text>().text = $"{hours}:0{minutes}";
            }
        }
        else if(minutes > 9)
        {
            if (hours < 9)
            {
                gameObject.GetComponent<Text>().text = $"0{hours}:{minutes}";
            }
            else
            {
                gameObject.GetComponent<Text>().text = $"{hours}:{minutes}";
            }
        }
        
    }
}
