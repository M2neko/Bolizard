using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour, ItemInterface
{
    int i = 0;
    bool completed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool activate()
    {
        Debug.Log("Computer Activated: " + i++);
        return true;
    }
}
