using UnityEngine;
using UnityEditor.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Interactable", order = 1)]
public class Interactable : ScriptableObject
{
    public GameObject scenePrefab;
   
 
    [TextArea(15, 20)]
    public string description;



}