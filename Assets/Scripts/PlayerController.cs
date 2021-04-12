using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 10f;
    private float mouseSpeed = 2000f;
    private float horizontal;
    private float vertical;
    private float mouseX;
    private float mouseY;

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
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontal);
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * vertical);
        transform.Rotate(Vector3.up * mouseSpeed * Time.deltaTime * mouseX);
    }
}
