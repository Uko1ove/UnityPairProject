using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IpadControllerSingle : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject screenOff;
    [SerializeField] GameObject screenOnLocked;
    [SerializeField] GameObject slider;
    [SerializeField] GameObject activeObjects;
    [SerializeField] GameObject itemContainer;

    public bool isUsed;
    private bool isScreenBlocked;
    private Vector3 ipadPosition;
    private Quaternion ipadRotation;
    private Vector3 ipadScale;

    public void Interact()
    {
        transform.parent = itemContainer.transform;

        transform.localPosition = new Vector3(0, 0, 0);
        transform.localRotation = Quaternion.identity;
        itemContainer.transform.localPosition = new Vector3(0, 1.57f, 0.35f);
        itemContainer.transform.localRotation = Quaternion.Euler(new Vector3(120, 0, 180));
    }


    void Start()
    {
        slider.GetComponent<Slider>().value = 0;
        isScreenBlocked = true;
        ipadPosition = transform.position;
        ipadRotation = transform.rotation;
        ipadScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && isUsed == true)
        {
            if (isScreenBlocked == false)
            {
                screenOnLocked.SetActive(true);
                slider.GetComponent<Slider>().value = 0;

            }
            isScreenBlocked = !isScreenBlocked;
            screenOff.SetActive(isScreenBlocked);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt) && isUsed == true)
        {
            PutIpad();
        }
    }

    private void PutIpad()
    {
        transform.parent = activeObjects.transform;
        transform.position = ipadPosition;
        transform.rotation = ipadRotation;
        transform.localScale = ipadScale;
        isScreenBlocked = true;
        isUsed = false;

        screenOff.SetActive(isScreenBlocked);
    }
}
