using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Tutorial/Item")]
public class Item : ScriptableObject
{
    public string name;
    public Sprite icon;
}
