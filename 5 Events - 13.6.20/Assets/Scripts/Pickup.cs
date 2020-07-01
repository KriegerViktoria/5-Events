using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public Inventory inventory;
    // public Item ScriptableObject;
    //public GameObject effect;
    //wenn ist isTransform == true dann liegt es in der Scene 
    //sonst ist es im inventar
    public bool isNeeded;
    public bool inRange = false;
    public GameObject inventoryObj;
    private CanvasGroup canvasGroup;
    public Lightswitch lightswitch;
    
  

    public void Awake()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        canvasGroup = inventoryObj.GetComponent<CanvasGroup>();
        // TexinInventory = itemButton.InventoryPicture;

        if (inRange == false)
        {
            this.gameObject.layer = 2;
        }

        if (inRange == true)
        {
            this.gameObject.layer = 0;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Range"))
        {
            print("Range Enter");
            inRange = true;
            this.gameObject.layer = 0;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Range"))
        {
            print("Range Exit");
            inRange = false;
            this.gameObject.layer = 2;
        }
    }

    public void OnMouseDown() { 

            if (inRange == true && isNeeded == true)
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
                        lightswitch.Light.SetActive(false);

                        this.gameObject.SetActive(false);

                        //DontDestroyOnLoad(ScriptableObject.inventoryPrefab);
                        //DontDestroyOnLoad(ScriptableObject.inventoryPrefab.transform);
                        break;

                    }
                }
            }
  
        }

    }
