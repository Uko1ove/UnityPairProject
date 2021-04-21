using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] GameObject smartphone;
    [SerializeField] GameObject screenOff;
    [SerializeField] GameObject screenOnLocked;
    [SerializeField] GameObject screenOnUnlocked;
    [SerializeField] GameObject slider;

    private const float playerSpeed = 10f;
    private const float mouseSpeed = 120f;
    private float horizontal;
    private float vertical;
    private float mouseX;
    private float mouseY;
    private float cameraRotation;
    private float rotationX = 0f;
    private bool isScreenOn;
    private Vector3 ipadPosition;
    private Quaternion ipadRotation;
    private Vector3 ipadScale;
    private bool isScreenBlocked;
    private PhotonView photonView;

    public bool isUsingSmartphone;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();

        isUsingSmartphone = false;
        ipadPosition = smartphone.transform.position;
        ipadRotation = smartphone.transform.rotation;
        ipadScale = smartphone.transform.localScale;
        isScreenBlocked = true;   
    }

    void Update()
    {
        if (!photonView.IsMine) return;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        cameraRotation = mainCamera.transform.rotation.x;

        if (isUsingSmartphone == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontal);
            transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * vertical);
            transform.Rotate(Vector3.up * mouseSpeed * Time.deltaTime * mouseX);

            rotationX += mouseY * mouseSpeed * Time.deltaTime;
            rotationX = Mathf.Clamp(rotationX, -30, 30);
            mainCamera.transform.localRotation = Quaternion.Euler(-rotationX, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) && isUsingSmartphone == true)
        {
            if (isScreenBlocked == true)
            {
                screenOnLocked.SetActive(true);
                slider.GetComponent<Slider>().value = 0;
            }
            screenOff.SetActive(!isScreenBlocked);
            isScreenBlocked = !isScreenBlocked;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isUsingSmartphone == true)
        {
            smartphone.transform.parent = null;
            smartphone.transform.position = ipadPosition;
            smartphone.transform.rotation = ipadRotation;
            smartphone.transform.localScale = ipadScale;
            isUsingSmartphone = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) )
            PhotonNetwork.LeaveRoom();
    }
}    
