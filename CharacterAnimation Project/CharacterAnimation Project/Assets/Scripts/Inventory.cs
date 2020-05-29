using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int[] items;
    public GameObject[] slots;

    public Item lastItem;

    private Inventory inventory;


    public void CheckCombination(Item CurrentItem)
    {
        print("Checking....");
        if (lastItem != null)
        {
            CurrentItem = lastItem;
            print("Item:" + lastItem);
        }

 //     else
 //
 //     if (CurrentItem == lastItem.Combinations.Ga)
 //     {
 //         for (int i = 0; i < inventory.items.Length; i++)
 //         {
 //             if (inventory.items[i] == 0)
 //             { // check whether the slot is EMPTY
 //               // Instantiate(effect, transform.position, Quaternion.identity);
 //                 inventory.items[i] = 1; // makes sure that the slot is now considered FULL
 //                 GameObject newGameObject = Instantiate(lastItem.Combinations, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
 //
 //                 RectTransform newRectTransform = newGameObject.GetComponent<RectTransform>();
 //                 newRectTransform.localPosition = Vector3.zero;
 //
 //                 Destroy(gameObject);
 //                 //DontDestroyOnLoad(ScriptableObject.inventoryPrefab);
 //                 //DontDestroyOnLoad(ScriptableObject.inventoryPrefab.transform);
 //                 break;
 //
 //             }
 //             //überprüfung welche Kombis möglich sind, wenn ja -> spawnt neues Item
 //             //wenn nicht ist current item=lastitem
 //         }
 //     }
 //

    }
}
