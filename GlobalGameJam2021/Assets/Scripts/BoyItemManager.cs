using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyItemManager : MonoBehaviour
{
    List<string> itemList = new List<string>();

    public bool pickupItem(string item)
    {
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Picked up item <"+ item + ">");
            itemList.Add(item);
            return true;
        }
        return false;
    }
    public void loseItem(string item)
    {
        itemList.Remove(item);
    }
    public bool hasItem(string item)
    {
        if (itemList.IndexOf(item) > 0)
            return true;
        else
            return false;

    }
}
