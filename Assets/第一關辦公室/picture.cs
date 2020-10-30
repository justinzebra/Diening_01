using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class picture : MonoBehaviour
{
    public int id = 0;
    int temp;
    public mainPicture _pctrl;
    bool b_appear = false;
    SpriteRenderer w;
    BoxCollider2D bw;
    private bool isright = true;
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
    public void D_Appear()
    {
        isright = false;
        
    }
    void OnMouseDrag()
    {
        
        Camera cam = Camera.main;      
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);  
        this.transform.position = new Vector3(newPos.x, newPos.y, -8.9f);
        
    }
  
    // void OnMouseUp()
    // { 
    //      if(isright==true)
    //     {
    //     transform.position = _pctrl.picturePos[id];
    //     }
    // }
    void OnTriggerEnter2D(Collider2D other)//碰撞後交換位置
    {
        
        foreach (picture p in _pctrl.allPicture)
        {
            if (p.id == other.GetComponent<pictureslot>().id)
            {
                temp = id;
                id = p.id;
                p.id = temp;
                // p.OnMouseUp();
            }
        }
      
    }
   
    // Start is called before the first frame update
    void Start()
    {
        _pctrl = transform.parent.GetComponent<mainPicture>();
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
