using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{

    public Transform playerPos;
    public Item lastItem;

    public void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void DropItem()
    {
        Instantiate(lastItem, playerPos.position, Quaternion.identity);
    }
}
