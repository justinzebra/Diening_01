 using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class book : MonoBehaviour
{
    public int id = 0;
    int temp;
    public mainBook _pctrl;
    bool b_appear = false;
    bool s_appear = false;
    SpriteRenderer w;
    BoxCollider2D bw;
    

    void OnMouseDrag()
    {
        Camera cam = Camera.main;      
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);  
        this.transform.position = new Vector3(newPos.x, newPos.y, -0.1f);
        
    }
    void SAppear()
    {
        if (s_appear == true)
        {
            w.enabled = true;
            
        }
        else
        {
            w.enabled = false;
            
        }
    }
    void BAppear()
    {
        if (b_appear == true)
        {
            
            bw.enabled = true;
        }
        else
        {
            
            bw.enabled = false;
        }
    }
    public void BConTrolAppear()
    {
        b_appear = true;
    }
    public void DisAppear()
    {
        b_appear = false;
        s_appear = false;
    }
    // void OnMouseUp()
    // { 
    //     transform.position = _pctrl.bookPos[id];
    // }
    void OnTriggerEnter2D(Collider2D other)//碰撞後交換位置
    {
        if (other.gameObject.tag == "book"&& gameObject.name=="F")
        {
            s_appear = true;
        }
        else if(other.gameObject.tag == "book"&& gameObject.name=="L")
        {
            s_appear = true;
        }
        else if(other.gameObject.tag == "book"&& gameObject.name=="D")
        {
            s_appear = true;
        }
        else if(other.gameObject.tag == "book"&& gameObject.name=="J")
        {
            s_appear = true;
        }
        else if(other.gameObject.tag == "book"&& gameObject.name=="P")
        {
            s_appear = true;
        }
        foreach (book b in _pctrl.allBook)
        {
            if (b.id == other.GetComponent<bookslot>().id)
            {
                temp = id;
                id = b.id;
                b.id = temp;
                // b.OnMouseUp();
            }
        }
      
    }
   
    // Start is called before the first frame update
    void Start()
    {
        _pctrl = transform.parent.GetComponent<mainBook>();
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        SAppear();
        BAppear();
    }
}
