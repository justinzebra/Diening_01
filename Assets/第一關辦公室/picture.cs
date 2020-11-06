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
        this.transform.position = new Vector3(newPos.x, newPos.y, -0.1f);
        
    }
  
    void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.gameObject.name=="pa"&&this.gameObject.name=="腦")
        {
            _pctrl.isBrain();
        }
        else if(other.gameObject.name=="pb"&&this.gameObject.name=="心")
        {
            _pctrl.isHeart();
        }
        else if(other.gameObject.name=="pc"&&this.gameObject.name=="肺")
        {
            _pctrl.isLung();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    { 
        if(other.gameObject.name=="pa"&&this.gameObject.name=="腦")
        {
            _pctrl.notBrain();
        }
        else if(other.gameObject.name=="pb"&&this.gameObject.name=="心")
        {
            _pctrl.notHeart();
        }
        else if(other.gameObject.name=="pc"&&this.gameObject.name=="肺")
        {
            _pctrl.notLung();
        }
    }
   
    // Start is called before the first frame update
    void Start()
    {
        _pctrl = _pctrl.GetComponent<mainPicture>();
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
