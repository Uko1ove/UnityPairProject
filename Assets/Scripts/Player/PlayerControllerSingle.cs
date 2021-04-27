using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControllerSingle : MonoBehaviour
{
    public Camera mainCamera;
    private GameObject smartphone;

    private float sliderValue;
    private const float playerSpeed = 10f;
    private const float mouseSpeed = 120f;
    private float horizontal;
    private float vertical;
    private float mouseX;
    private float mouseY;
    private float cameraRotation;
    private float rotationX = 0f;
    private Rigidbody rigidBody;
    private Transform objectTransform;
    private Vector3 direction, position;
    public bool isUsingSmartphone;

    public bool IsScreenBlocked
    {
        get; private set;
    }



    void Start()
    {
        smartphone = GameObject.FindGameObjectWithTag("ipad");
        IsScreenBlocked = true;
        isUsingSmartphone = false;
        rigidBody = GetComponent<Rigidbody>();
        objectTransform = GetComponent<Transform>();
        position = objectTransform.position;
    }

    void Update()
    {
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
            IsScreenBlocked = !IsScreenBlocked;
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt) && isUsingSmartphone == true)
        {
            IsScreenBlocked = true;
            isUsingSmartphone = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Отображение внутриигрового меню: Save, Load, Exit
        }
    }
}
