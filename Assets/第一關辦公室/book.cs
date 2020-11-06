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
    bool b_appear = true;
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
   
    void OnTriggerEnter2D(Collider2D other)
    {
        //控制書出現
        if (other.gameObject.name == "背包裡的F"&& gameObject.name=="F")
        {
            s_appear = true;
        }
        else if(other.gameObject.name == "背包裡的L"&& gameObject.name=="L")
        {
            s_appear = true;
        }
        else if(other.gameObject.name == "背包裡的D"&& gameObject.name=="D")
        {
            s_appear = true;
        }
        else if(other.gameObject.name == "背包裡的J"&& gameObject.name=="J")
        {
            s_appear = true;
        }
        else if(other.gameObject.name == "背包裡的P"&& gameObject.name=="P")
        {
            s_appear = true;
        }
       
        if(other.gameObject.name=="bb"&&this.gameObject.name=="D")
        {
            _pctrl.isD();
        }
        else if(other.gameObject.name=="bd"&&this.gameObject.name=="F")
        {
            _pctrl.isF();
        }
        else if(other.gameObject.name=="ba"&&this.gameObject.name=="J")
        {
            _pctrl.isJ();
        }
        else if(other.gameObject.name=="bc"&&this.gameObject.name=="L")
        {
            _pctrl.isL();
        }
        else if(other.gameObject.name=="be"&&this.gameObject.name=="P")
        {
            _pctrl.isP();
        }
      
    }
    void OnTriggerExit2D(Collider2D other)
    { 
         if(other.gameObject.name=="bb"&&this.gameObject.name=="D")
        {
            _pctrl.notD();
        }
        else if(other.gameObject.name=="bd"&&this.gameObject.name=="F")
        {
            _pctrl.notF();
        }
        else if(other.gameObject.name=="ba"&&this.gameObject.name=="J")
        {
            _pctrl.notJ();
        }
        else if(other.gameObject.name=="bc"&&this.gameObject.name=="L")
        {
            _pctrl.notL();
        }
        else if(other.gameObject.name=="be"&&this.gameObject.name=="P")
        {
            _pctrl.notP();
        }
    }
   
    // Start is called before the first frame update
    void Start()
    {
        _pctrl = _pctrl.GetComponent<mainBook>();
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
