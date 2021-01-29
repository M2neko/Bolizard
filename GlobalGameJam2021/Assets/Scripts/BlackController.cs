using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackController : MonoBehaviour
{
    [SerializeField] private float Darklast = 0.5f;
    [SerializeField] private float Brightlast = 3.0f;
    private float time = 0.0f;
    private float Darktime = 0.0f;
    public bool isDark = false;
    // Start the game?
    public bool startGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDark)
        {
            Darktime += Time.deltaTime;
            if (Darktime >= Darklast)
            {
                isDark = false;
                time = 0.0f;
                Darktime = 0.0f;
            }
        }
        else
        {
            time += Time.deltaTime;
            if (time >= Brightlast)
            {
                // Sound
                gameObject.GetComponent<AudioSource>().Play();
                isDark = true;
                time = 0.0f;
                Darktime = 0.0f;
            }
        }



        if (isDark)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
