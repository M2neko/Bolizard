using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtCamMove : MonoBehaviour
{
    [SerializeField] private GameObject Boy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(Boy.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

        if (gameObject.transform.position.x <= -2.29f)
        {
            gameObject.transform.position = new Vector3(-2.29f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.x >= 1.85f)
        {
            gameObject.transform.position = new Vector3(1.85f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

    }
}
