using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inventory inventory;
    public Item ScriptableObject;
    //public GameObject effect;
    //wenn ist isTransform == true dann liegt es in der Scene 
    //sonst ist es im inventar
    private bool isTransform;


 

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        // TexinInventory = itemButton.InventoryPicture;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            print("Collider hit");
            isTransform = false;

            if (isTransform == false)
            {

                for (int i = 0; i < inventory.items.Length; i++)
                {
                    if (inventory.items[i] == 0)
                    { // check whether the slot is EMPTY
                      // Instantiate(effect, transform.position, Quaternion.identity);
                        inventory.items[i] = 1; // makes sure that the slot is now considered FULL
                        Instantiate(ScriptableObject.inventoryPrefab, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                        Destroy(gameObject);
                        break;
                    }
                }
            }
            else
            {
                isTransform = true;

            }
    }

    }
}
