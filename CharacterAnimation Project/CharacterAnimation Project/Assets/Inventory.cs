using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : ScriptableObject
{
    public List<Item> Container = new List<Item>();

}

[System.Serializable]
public class InventorySlot
{
    public Item item;
    public InventorySlot(Item _item)
    {
        item = _item;
    }
}