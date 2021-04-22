using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChangeDaylight : MonoBehaviour
{
    [SerializeField] GameObject arrowHour;
    private float rotationAngle;
    private float hourRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        hourRotation = arrowHour.transform.eulerAngles.z;
        rotationAngle = transform.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (arrowHour.transform.eulerAngles.z != hourRotation)
        {
            hourRotation = arrowHour.transform.eulerAngles.z;
            transform.Rotate(Vector3.right, 0.25f);
        } 
    }

    
    
}
