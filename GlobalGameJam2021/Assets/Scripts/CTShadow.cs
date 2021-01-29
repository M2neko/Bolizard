using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTShadow : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Called");
        BoyColor bc = other.GetComponent<BoyColor>();
        if(bc != null)
        {
            bc.setColorDark();
        }
    }

}
