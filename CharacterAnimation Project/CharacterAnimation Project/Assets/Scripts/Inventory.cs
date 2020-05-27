using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int[] items;
    public GameObject[] slots;

    public Item lastItem;
    

    public void CheckCombination(Item CurrentItem)
    {

        //überprüfung welche Kombis möglich sind, wenn ja -> spawnt neues Item
        //wenn nicht ist current item=lastitem
    }


}
