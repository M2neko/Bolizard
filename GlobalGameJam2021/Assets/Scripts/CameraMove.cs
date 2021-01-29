using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
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

        if (gameObject.transform.position.x <= 0.0f)
        {
            gameObject.transform.position = new Vector3(0.0f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.x >= 17.63f)
        {
            gameObject.transform.position = new Vector3(17.63f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

    }
}
