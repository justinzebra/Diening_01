﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Text2 : MonoBehaviour
{
    bool b_appear = false;
    SpriteRenderer w;
    

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            b_appear = true;
            Invoke("ObjectDestroy",4);
        }
    //    Invoke("ObjectDestroy",4);
    }
    void ObjectDestroy()
    {
        Destroy(gameObject);
    }
   
    void Appear()
    {
        if (b_appear == true)
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
