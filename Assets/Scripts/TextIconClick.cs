using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextIconClick : MonoBehaviour
{
    [SerializeField] GameObject textFileWrapper;
    [SerializeField] GameObject textFile;
    [SerializeField] GameObject chekedImage;
    private const float doubleCkilckTime = 0.16f;
    private float lastClickTime;
    public string fileText
    {
        get; private set;
    }

    private void Start()
    {
        fileText = textFile.GetComponent<InputField>().text;
        PlayerPrefs.SetString("fileText", fileText);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if((Time.time - lastClickTime) <= doubleCkilckTime)
            {
                fileText = PlayerPrefs.GetString("fileText");
                textFile.GetComponent<InputField>().text = fileText;
                textFileWrapper.SetActive(true);
                
            }
            else
            {
                chekedImage.SetActive(true);
                
            }

            lastClickTime = Time.time;
        }
        
    }

    
}
