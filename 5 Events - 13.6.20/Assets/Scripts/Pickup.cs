using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inventory inventory;
   // public Item ScriptableObject;
    //public GameObject effect;
    //wenn ist isTransform == true dann liegt es in der Scene 
    //sonst ist es im inventar
    private bool isTransform;
    public bool isNeeded;
    public GameObject inventoryObj;
    private CanvasGroup canvasGroup;


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        canvasGroup = inventoryObj.GetComponent<CanvasGroup>();
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
                        inventoryObj.transform.position = inventory.slots[i].transform.position;
                        inventoryObj.transform.SetParent(inventory.slots[i].transform);
                        // GameObject newGameObject = Instantiate(ScriptableObject.inventoryPrefab, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                        //
                        // RectTransform newRectTransform = newGameObject.GetComponent<RectTransform>();
                        // newRectTransform.localPosition = Vector3.zero;
                        //
                        
                        inventoryObj.SetActive(true);
                        canvasGroup.blocksRaycasts = true;

                        this.gameObject.SetActive(false);

                        //DontDestroyOnLoad(ScriptableObject.inventoryPrefab);
                        //DontDestroyOnLoad(ScriptableObject.inventoryPrefab.transform);
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
