using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    private const float playerSpeed = 10f;
    private const float mouseSpeed = 120f;
    private float horizontal;
    private float vertical;
    private float mouseX;
    public float mouseY;
    private float cameraRotation;
    private float rotationX = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
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

    }
}
