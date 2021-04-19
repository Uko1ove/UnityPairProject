using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFileController : MonoBehaviour
{
    [SerializeField] GameObject textFileWrapper;
    private string fileText;

    public void CloseTextFile()
    {
        textFileWrapper.SetActive(false);
    }

    public void SaveTextFile()
    {
        fileText = gameObject.GetComponent<InputField>().text;
        PlayerPrefs.SetString("fileText", fileText);
        PlayerPrefs.Save();
        gameObject.GetComponent<InputField>().text = fileText;
    }
}
