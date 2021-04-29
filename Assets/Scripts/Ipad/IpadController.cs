using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class IpadController : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject screenOff;
    [SerializeField] GameObject screenOnLocked;
    [SerializeField] GameObject slider;
    [SerializeField] GameObject activeObjects;
    PhotonView photonView;

    private GameObject itemContainer;
    public bool isUsed;
    private float sliderValue;
    private bool isScreenBlocked;
    private Vector3 ipadPosition;
    private Quaternion ipadRotation;
    private Vector3 ipadScale;

    public void Interact()
    {
        photonView = GetComponent<PhotonView>();


        transform.parent = itemContainer.transform;

        transform.localPosition = new Vector3(0, 0, 0);
        transform.localRotation = Quaternion.identity;
        itemContainer.transform.localPosition = new Vector3(0, 1.57f, 0.35f);
        itemContainer.transform.localRotation = Quaternion.Euler(new Vector3(120, 0, 180));

        photonView.RPC("OthersTakeIpad", RpcTarget.Others);
    }

    [PunRPC]
    void OthersTakeIpad()
    {
        transform.localPosition = new Vector3(0, 0, 0);
        transform.localRotation = Quaternion.identity;
    }

    void Start()
    {
        itemContainer = GameObject.FindGameObjectWithTag("item");

        sliderValue = 0;
        isScreenBlocked = true;
        ipadPosition = transform.position;
        ipadRotation = transform.rotation;
        ipadScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && isUsed == true)
        {
            if(isScreenBlocked == false)
            {
                screenOnLocked.SetActive(true);
                slider.GetComponent<Slider>().value = 0;

            }
            isScreenBlocked = !isScreenBlocked;
            screenOff.SetActive(isScreenBlocked);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt) && isUsed == true)
        {
            photonView.RPC("PutIpad", RpcTarget.All);
        }
    }

    [PunRPC]
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
