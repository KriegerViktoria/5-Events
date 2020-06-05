using UnityEngine;
using UnityEditor.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Combination", order = 1)]
public class Combination : ScriptableObject
{
    public Item ItemA;
    public Item ItemB;
    public Item Result;

    [TextArea(15, 20)]
    public string description;

    public bool Consumable;
}

