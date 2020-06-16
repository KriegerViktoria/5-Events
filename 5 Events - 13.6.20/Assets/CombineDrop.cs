using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CombineDrop : MonoBehaviour, IDropHandler
{
    public GameObject ItemToCombineWith;
    public GameObject Result;
    private RectTransform rectTransform;
    Vector3 currentposition;
    private GameObject objects;
    private Inventory inventory;
    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        objects = GameObject.Find("__________CAM UI__________/Canvas/Objects");
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        currentposition = rectTransform.anchoredPosition;
        // Debug.Log("OnDrop");

        if (eventData.pointerDrag == ItemToCombineWith)
        {
            this.gameObject.SetActive(false);
            this.gameObject.transform.SetParent(objects.transform);
            eventData.pointerDrag.SetActive(false);
            eventData.pointerDrag.transform.SetParent(objects.transform);

            for (int i = 0; i < inventory.items.Length; i++)
            {
                if (inventory.items[i] == 0)
                { 
                    inventory.items[i] = 1; // makes sure that the slot is now considered FULL
                    Result.transform.position = inventory.slots[i].transform.position;
                    Result.transform.SetParent(inventory.slots[i].transform);


                    //DontDestroyOnLoad(ScriptableObject.inventoryPrefab);
                    //DontDestroyOnLoad(ScriptableObject.inventoryPrefab.transform);
                    break;
                }
                print("Combine");

            }

        }
    }
}
