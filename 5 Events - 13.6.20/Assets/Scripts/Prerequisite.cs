using System.Collections;

using UnityEngine;

public class Prerequisite : MonoBehaviour
{
    public bool requireItem;
    public Inventory InventoryScript;
    public Item[] InteractionWith;



    //if true block access
    public bool nodeAcces;

    public void CheckInteractions()
    {
        if (InventoryScript.lastItem.name == InteractionWith[0].name) 
        {
            print("Found Interaction");
         //  Destroy(InventoryScript.lastItem);
            requireItem = false;
        }
    }

}
