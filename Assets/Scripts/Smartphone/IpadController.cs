using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class IpadController : MonoBehaviour, IInteractable
{
    GameObject player;
    [SerializeField] GameObject screenOff;
    [SerializeField] GameObject screenOnLocked;
    [SerializeField] GameObject slider;
    PhotonView photonView;

    private GameObject itemContainer;
    private bool isUsed;
    private float sliderValue;
    private bool isScreenBlocked;
    private Vector3 ipadPosition;
    private Quaternion ipadRotation;
    private Vector3 ipadScale;

    public void Interact()
    {
        transform.parent = itemContainer.transform;
        
        transform.localPosition = new Vector3(0, 0, 0);
        transform.localRotation = Quaternion.identity;
        itemContainer.transform.localPosition = new Vector3(0, 0, 0.2f);
        itemContainer.transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 180));
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        sliderValue = 0;
        isScreenBlocked = true;
        ipadPosition = transform.position;
        ipadRotation = transform.rotation;
        ipadScale = transform.localScale;
        itemContainer = player.GetComponent<PlayerController>().mainCamera.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        isUsed = player.GetComponent<PlayerController>().isUsingSmartphone;
        isScreenBlocked = player.GetComponent<PlayerController>().IsScreenBlocked;
        sliderValue = slider.GetComponent<Slider>().value;
        
        if (isUsed)
        {
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
        else
        {
            screenOff.SetActive(isScreenBlocked);
            screenOnLocked.SetActive(true);
            transform.parent = null;
            transform.position = ipadPosition;
            transform.rotation = ipadRotation;
            transform.localScale = ipadScale;
        }
    }
}
