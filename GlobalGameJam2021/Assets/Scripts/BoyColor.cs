using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyColor : MonoBehaviour
{
    Color oldColor;
    // Start is called before the first frame update

    public void setColorDark()
    {
        Debug.Log("Called");
        var color = new Color(0.5f, 0.5f, 0.5f);
        oldColor = color;
        gameObject.GetComponent<SpriteRenderer>().color = color;
    }

    public void resetColor()
    {
        gameObject.GetComponent<SpriteRenderer>().color = oldColor;
    }
}
