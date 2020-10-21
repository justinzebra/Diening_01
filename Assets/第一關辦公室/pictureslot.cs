using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pictureslot : MonoBehaviour
{
    public int id = 0;
    bool bs_appear = false;
    CircleCollider2D bw;
    private bool isright = true;
    public void ConTrolAppearbs()
    {
        bs_appear = true;
    }
    public void DisAppear()
    {
        bs_appear = false;
        
    }
    public void D_Appear()
    {
        isright = false;
        
    }
    void Appear()
    {
        if (bs_appear == true&&isright==true)
        {
            
            bw.enabled = true;
        }
        else
        {
            
            bw.enabled = false;
        }
    }
     void Start()
    {
       
        bw = GetComponent<CircleCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
