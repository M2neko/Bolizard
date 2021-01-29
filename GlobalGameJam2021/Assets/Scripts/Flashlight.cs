using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
