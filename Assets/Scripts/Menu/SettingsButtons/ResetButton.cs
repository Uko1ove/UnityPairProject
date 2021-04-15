using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public GameObject goOut_0;
    public GameObject goOut_1;
    public GameObject goOut_2;

    public GameObject goIn_0;

    public void ResetGame()
    {
        Text text1 = GetComponentInChildren<Text>();

        if (goOut_0.activeInHierarchy == true)
        {
            text1.text = "No";

            goOut_0.SetActive(false);
            goOut_1.SetActive(false);
            goOut_2.SetActive(false);

            goIn_0.SetActive(true);
        }
        else
        {
            text1.text = "Reset Progress";

            goOut_0.SetActive(true);
            goOut_1.SetActive(true);
            goOut_2.SetActive(true);

            goIn_0.SetActive(false);
        }
    }
}
