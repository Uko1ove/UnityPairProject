using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControllerSingle : MonoBehaviour
{
    [SerializeField] GameObject Panel; 
    public Camera mainCamera;
    [SerializeField] GameObject ipad;

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

    public bool IsScreenBlocked
    {
        get; private set;
    }

    void Start()
    {
        IsScreenBlocked = true;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        cameraRotation = mainCamera.transform.rotation.x;
        
        if (ipad.GetComponent<IpadControllerSingle>().isUsed == false && Panel.activeInHierarchy == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontal);
            transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * vertical);
            transform.Rotate(Vector3.up * mouseSpeed * Time.deltaTime * mouseX);

            rotationX += mouseY * mouseSpeed * Time.deltaTime;
            rotationX = Mathf.Clamp(rotationX, -50, 30);
            mainCamera.transform.localRotation = Quaternion.Euler(-rotationX, 0, 0);

            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(!Panel.activeInHierarchy);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
