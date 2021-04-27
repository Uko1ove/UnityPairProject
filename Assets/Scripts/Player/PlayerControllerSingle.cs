using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerSingle : MonoBehaviour
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

    public bool isUsingSmartphone;

    // Start is called before the first frame update
    void Start()
    {
        smartphone = GameObject.FindGameObjectWithTag("ipad");
        screenOff = smartphone.GetComponent<IpadControllerSingle>().ScreenOff;
        slider = smartphone.GetComponent<IpadControllerSingle>().Slider;

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
            /*if (IsScreenBlocked == false)
            {
                IsScreenLocked = true;
            }*/
        }

        if (Input.GetKeyDown(KeyCode.Space) && isUsingSmartphone == true)
        {
            smartphone.transform.parent = null;
            smartphone.transform.position = ipadPosition;
            smartphone.transform.rotation = ipadRotation;
            smartphone.transform.localScale = ipadScale;
            isUsingSmartphone = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Menu");
    }
}
