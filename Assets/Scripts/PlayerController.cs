using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    private GameObject smartphone;
    private GameObject screenOff;
    private GameObject screenOnLocked;
    private GameObject slider;

    private float sliderValue;
    private const float playerSpeed = 10f;
    private const float mouseSpeed = 120f;
    private float horizontal;
    private float vertical;
    private float mouseX;
    private float mouseY;
    private float cameraRotation;
    private float rotationX = 0f;

    private Vector3 ipadPosition;
    private Quaternion ipadRotation;
    private Vector3 ipadScale;

    public bool IsScreenBlocked
    {
        get; private set;
    }

    public bool IsScreenLocked
    {
        get; private set;
    }

    private PhotonView photonView;

    public bool isUsingSmartphone;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();

        smartphone = GameObject.FindGameObjectWithTag("ipad");
        screenOff = smartphone.GetComponent<IpadController>().ScreenOff;
        slider = smartphone.GetComponent<IpadController>().Slider;

        ipadPosition = smartphone.transform.position;
        ipadRotation = smartphone.transform.rotation;
        ipadScale = smartphone.transform.localScale;
        IsScreenBlocked = screenOff.activeSelf;
        IsScreenLocked = true;
        isUsingSmartphone = false;

        isUsingSmartphone = false;
        ipadPosition = smartphone.transform.position;
        ipadRotation = smartphone.transform.rotation;
        ipadScale = smartphone.transform.localScale;
        //isScreenBlocked = true;
    }

    void Update()
    {
        if (!photonView.IsMine) return;
        if (photonView.IsMine) mainCamera.gameObject.SetActive(true);

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        cameraRotation = mainCamera.transform.rotation.x;

        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontal);
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * vertical);
        transform.Rotate(Vector3.up * mouseSpeed * Time.deltaTime * mouseX);

        rotationX += mouseY * mouseSpeed * Time.deltaTime;
        rotationX = Mathf.Clamp(rotationX, -30, 30);
        mainCamera.transform.localRotation = Quaternion.Euler(-rotationX, 0, 0);

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
            IsScreenBlocked = !IsScreenBlocked;
            IsScreenLocked = !IsScreenLocked;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isUsingSmartphone == true)
        {
            smartphone.transform.parent = null;
            smartphone.transform.position = ipadPosition;
            smartphone.transform.rotation = ipadRotation;
            smartphone.transform.localScale = ipadScale;
            isUsingSmartphone = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
            PhotonNetwork.LeaveRoom();
    }
}
