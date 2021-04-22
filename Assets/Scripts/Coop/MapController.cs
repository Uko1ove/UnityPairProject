using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject ActionObjects;

    void Start()
    {
        Instantiate(ActionObjects);
    }


    void Update()
    {
        
    }
}
