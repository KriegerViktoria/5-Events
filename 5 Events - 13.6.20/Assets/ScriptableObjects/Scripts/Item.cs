using UnityEngine;
using UnityEditor.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/InventoryItem", order = 1)]
public class Item : ScriptableObject
{
    public GameObject scenePrefab;
    public GameObject inventoryPrefab;

    public Combination[] Combinations;
    public GameObject[] InteractionWith;

    [TextArea(15,20)]
    public string description;

    public bool Consumable;

}
