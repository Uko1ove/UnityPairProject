using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    GameObject Panel;
    public Camera mainCamera;
    private GameObject ipad;

    private float sliderValue;
    private const float playerSpeed = 10f;
    private const float mouseSpeed = 120f;
    private float horizontal;
    private float vertical;
    private float mouseX;
    private float mouseY;
    private float cameraRotation;
    private float rotationX = 0f;
    private PhotonView photonView;
    bool esc;

    public bool IsScreenBlocked
    {
        get; private set;
    }

    void Start()
    {
        photonView = GetComponent<PhotonView>();

        ipad = GameObject.FindGameObjectWithTag("ipad");

        IsScreenBlocked = true;
        esc = false;
    }

    void Update()
    {
        if (!photonView.IsMine) return;

        mainCamera.gameObject.SetActive(true);
        GetComponent<AudioListener>().enabled = true;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        cameraRotation = mainCamera.transform.rotation.x;

        if (ipad.GetComponent<IpadController>().isUsed == false && esc == false)
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
            Panel = GameObject.FindGameObjectWithTag("link_panel");
            Panel = Panel.GetComponent<CoopManager>().Panel;
            Panel.SetActive(!Panel.activeInHierarchy);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            esc = !esc;
        }
    }
}
