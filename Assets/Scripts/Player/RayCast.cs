using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject itemContainer;
    public float rayDistance;
    private bool isUsingSmart;
    private Camera cam;

    void Update()
    {
        var playerController = player.GetComponent<PlayerController>();
        if (playerController != null)
        {
            isUsingSmart = playerController.isUsingSmartphone;
        }
        cam = GetComponent<Camera>();
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, ray.direction * rayDistance);

        RaycastHit hit;

        if(Input.GetMouseButtonDown(0) )
        {
            if (Physics.Raycast(ray, out hit, rayDistance) && hit.collider.gameObject.tag == "object")
            {
                var interactComponent = hit.collider.GetComponent<IInteractable>();
                interactComponent.Interact();
            }
            
            if (Physics.Raycast(ray, out hit, rayDistance) && hit.collider.gameObject.name == "ipad")
            {
                if (isUsingSmart == false)
                {
                    var interactComponent = hit.collider.GetComponent<IInteractable>();
                    interactComponent.Interact();
                    
                    isUsingSmart = true;
                    player.GetComponent<PlayerController>().isUsingSmartphone = isUsingSmart;
                }
            }
        }
    }
}
