using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    private float playerSpeed = 10f;
    private float mouseSpeed = 120f;
    private float horizontal;
    private float vertical;
    private float mouseX;
    public float mouseY;
    private float cameraRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

        // Какая-то жопа. Не понимаю, как сделать ограничения на вертикальное вращение камеры.
        mainCamera.transform.Rotate(-Vector3.right * mouseSpeed * Time.deltaTime * mouseY);





    }
}
