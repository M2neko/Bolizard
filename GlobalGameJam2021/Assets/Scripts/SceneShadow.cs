using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneShadow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        BoyColor bc = other.GetComponent<BoyColor>();
        if(bc != null)
        {
            bc.setColorDark();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        BoyColor bc = other.GetComponent<BoyColor>();
        if (bc != null)
        {
            bc.resetColor();
        }
    }

}
