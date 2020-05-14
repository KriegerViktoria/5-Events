using UnityEngine;
using UnityEditor.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Combination", order = 1)]
public class Combination : ScriptableObject
{
    public GameObject ItemA;
    public GameObject ItemB;
    public GameObject Result;

    public GameObject[] InteractionWith;
    [TextArea(15, 20)]
    public string description;

    public bool Consumable;
}

