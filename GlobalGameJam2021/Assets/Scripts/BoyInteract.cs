using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyInteract : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.F))
        {
            string name = collision.name;
            switch (name)
            {
                case "CT Computer":
                    collision.GetComponent<Computer>().activate();
                    break;
                default:
                    break;
            }
        }
    }
}