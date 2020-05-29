using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{

    public Transform playerPos;
    Item DropItem;

    public void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void ItemDrop()
    {
      
        Instantiate(lastItem, playerPos.position, Quaternion.identity);
    }
}
