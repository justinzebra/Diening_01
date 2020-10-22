using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartpicture : MonoBehaviour
{
    bool b_appear = false;
    SpriteRenderer w;
    BoxCollider2D bw;
    public void ConTrolAppear()
    {
        b_appear = true;
    }
    void Appear()
    {
        if (b_appear == true)
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
    public void DisAppear()
    {
        b_appear = false;
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
