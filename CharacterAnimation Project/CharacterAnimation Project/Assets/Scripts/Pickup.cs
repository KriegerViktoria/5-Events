using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;
    public Item ScriptableObject;
    //public GameObject effect;

    private SpriteRenderer Icon;

 

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        // TexinInventory = itemButton.InventoryPicture;
        Icon = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            print("Collider hit");

            for (int i = 0; i < inventory.items.Length; i++)
            {
                if (inventory.items[i] == 0){ // check whether the slot is EMPTY
                  // Instantiate(effect, transform.position, Quaternion.identity);
                    inventory.items[i] = 1; // makes sure that the slot is now considered FULL
                    Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                    Icon.sortingLayerName = "UI";
                    Icon.sortingOrder = 1;
                    Destroy(gameObject);
                    break;
                }
            }
        }

    }
}
