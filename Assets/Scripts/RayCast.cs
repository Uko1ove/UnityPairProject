using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float rayDistance;


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Debug.DrawRay(transform.position, ray.direction * rayDistance);
     
        if ( Physics.Raycast(ray , out hit , rayDistance) && hit.collider.gameObject.tag == "object" && Input.GetMouseButtonDown(0) )
        {
            var interactComponent = hit.collider.GetComponent<IInteractable>();
            interactComponent.Interact();
        }
    }
}
