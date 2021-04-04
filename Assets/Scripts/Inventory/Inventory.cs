using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> InventoryAll = new List<Item>();
    public List<Item> InventoryLoad { get; private set; }

    void Awake()
    {
        InventoryLoad = new List<Item>();
        string inventory = PlayerPrefs.GetString("Inventory", "000000000");
            for (int i = 0; i < 9; i++)
                if (inventory[i] != '0')
                    InventoryLoad[InventoryLoad.Count] = InventoryAll[i];
    }
}
