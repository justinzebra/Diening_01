using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookslot : MonoBehaviour
{
    public int id = 0;
    bool bs_appear = false;
    SpriteRenderer w;
    CircleCollider2D bw;
    public void ConTrolAppearbs()
    {
        bs_appear = true;
    }
    void Appear()
    {
        if (bs_appear == true)
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
     void Start()
    {
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<CircleCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Appear();
    }
}
