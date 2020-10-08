using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class bodycheck : MonoBehaviour
{
    SpriteRenderer w;
    bool b_appear = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "xray")
        {
            b_appear = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "xray")
        {
            b_appear = false;
        }
    }
    void Appear()
    {
        if (b_appear == false)
        {
            w.enabled = true;

        }
        else
        {
            w.enabled = false;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        w = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
