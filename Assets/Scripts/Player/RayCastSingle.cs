using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RayCastSingle : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject itemContainer;
    public float rayDistance;
    private bool isUsingSmart;
    private Camera cam;

    private void Start()
    {
        var playerController = player.GetComponent<PlayerControllerSingle>();
        if(playerController != null)
        {
            isUsingSmart = playerController.isUsingSmartphone;
        }     
    }

    void Update()
    {
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
            
            if (Physics.Raycast(ray, out hit, rayDistance) && hit.collider.gameObject.name == "smartphone")
            {
                if (isUsingSmart == false)
                {
                    GameObject go1 = hit.collider.gameObject;
                    go1.transform.parent = itemContainer.transform;
                    
                    go1.transform.localPosition = new Vector3(0, 0, 0);
                    go1.transform.localRotation = Quaternion.identity;
                    itemContainer.transform.localPosition = new Vector3(0, 0, 0.2f);
                    itemContainer.transform.localRotation = Quaternion.Euler(new Vector3(90, 0, 180));
                    isUsingSmart = true;
                    player.GetComponent<PlayerControllerSingle>().isUsingSmartphone = isUsingSmart;
                }

                isUsingSmart = player.GetComponent<PlayerControllerSingle>().isUsingSmartphone;
            }
        }
    }
}
