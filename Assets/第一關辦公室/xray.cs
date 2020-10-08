using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xray : MonoBehaviour
{
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool Canmove = true;
    void OnMouseDrag()
    {
        Camera cam = Camera.main;      
        Vector3 newPos = cam.ScreenToWorldPoint(Input.mousePosition);  
        this.transform.position = new Vector3(newPos.x, newPos.y, -8.9f);
        
    }
    void Move()
    {
        if (Input.GetKey("up")|| Input.GetKey("w")) { transform.Translate(0, 0.015f, 0); }
      
        if (Input.GetKey("down")|| Input.GetKey("s")) { transform.Translate(0, -0.015f, 0); }
        
        if (Input.GetKey("left")|| Input.GetKey("a")) { transform.Translate(-0.015f, 0, 0); }
       
        if (Input.GetKey("right")|| Input.GetKey("d")) { transform.Translate(0.015f, 0, 0); }
        
    }
    public void ReStopMove()
    {
        Canmove = false;

    }
    public void StartMove()
    {
        Canmove = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Canmove == true)
        {
            Move();
        }
    }
}
