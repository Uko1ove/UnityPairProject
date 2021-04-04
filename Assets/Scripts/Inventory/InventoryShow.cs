using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryShow : MonoBehaviour
{
    [SerializeField] Inventory targetInventory;
    [SerializeField] RectTransform itemPanel;


    void Start()
    {
        Redraw();
    }

    void Redraw()
    {
        for (var i = 0; i < targetInventory.InventoryLoad.Count; i++)
        {
            var item = targetInventory.InventoryLoad[i];
            if (item != null)
            {
                Instantiate(item, itemPanel);
            }
        }
    }
}
