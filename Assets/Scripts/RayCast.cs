using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float rayDistance;
    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, ray.direction * rayDistance);

        if (Physics.Raycast(ray, rayDistance))
        {
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
        }
    }
}
