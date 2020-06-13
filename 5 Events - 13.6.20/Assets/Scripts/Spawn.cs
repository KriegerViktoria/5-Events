using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public Transform playerPos;
    public GameObject item;

    public void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void SpawnItem() {
        Instantiate(item, playerPos.position, Quaternion.identity);
    }
}
