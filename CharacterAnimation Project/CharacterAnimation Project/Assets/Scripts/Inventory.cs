using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int[] items;
    public GameObject[] slots;

    public bool firstClick = true;
    public Item lastItem;
    


    public void CheckCombination(Item CurrentItem)
    {
        print("Checking....");
        if (firstClick)
        {
            lastItem = CurrentItem;
            print("Item:" + lastItem);
            firstClick = false;
        }
        else
        {
            for (int j = 0; j < CurrentItem.Combinations.Length; j++)
            {
                print(j);
                print("item:" + lastItem);
                if (CurrentItem.Combinations[j].ItemB == lastItem)
                {
                    print("Combination found" + CurrentItem.Combinations[j].Result);
                    for (int i = 0; i < items.Length; i++)
                    //test 06.06.2020
                    {
                        if (items[i] == 0)
                        {   // check whether the slot is EMPTY
                            // Instantiate(effect, transform.position, Quaternion.identity);
                            items[i] = 1; // makes sure that the slot is now considered FULL
                            Instantiate(lastItem.Combinations[j].Result.inventoryPrefab, slots[i].transform, false); // spawn the button so that the player can interact with it
                            firstClick = true;
                            lastItem = null;
                           // RectTransform newRectTransform = newGameObject.GetComponent<RectTransform>();
                            //newRectTransform.localPosition = Vector3.zero;

                            //Destroy(gameObject);
                            // break;

                        }
                    }
                }
                //if (CurrentItem.Combinations[0].ItemB == lastItem)
                //{
                //
                //} 
            }
        }
        //     if (CurrentItem != lastItem.Combinations.)
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


    }
}

