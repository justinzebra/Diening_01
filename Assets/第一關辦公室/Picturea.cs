using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picturea : MonoBehaviour
{
    bool p_appear = false;
    SpriteRenderer w;
    BoxCollider2D bw;
    public void ConTrolAppear()
    {
        p_appear = true;
    }
     public void DisAppear()
    {
        p_appear = false;
    }
     void Appear()
    {
        if (p_appear == true)
        {
            w.enabled = true;
            bw.enabled = true;
        }
        else
        {
            w.enabled = false;
            bw.enabled = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
