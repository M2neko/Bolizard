using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        BoyItemManager itemManager = collision.GetComponent<BoyItemManager>();
        if(itemManager != null)
        {
            if(itemManager.pickupItem("Flashlight"))
                GameObject.Destroy(gameObject);
        }
    }
}
