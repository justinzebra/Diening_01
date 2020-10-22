using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_picture2 : MonoBehaviour
{
   public Player AA;
    public Picturea BB;
    public picture2 cc0;
    public picture2 cc1;
    public picture2 cc2;
    public windowaback bb;
    
    BoxCollider2D bw;
    
    // Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<Player>();
        BB = BB.GetComponent<Picturea>();
        cc0 = cc0.GetComponent<picture2>();
        cc1 = cc1.GetComponent<picture2>();
        cc2 = cc2.GetComponent<picture2>();
        bb = bb.GetComponent<windowaback>();
        bw = GetComponent<BoxCollider2D>();
        
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "picture2")
        {
            AA.StopMove();
            BB.ConTrolAppear();
            cc0.ConTrolAppear();
            cc1.ConTrolAppear();
            cc2.ConTrolAppear();
            bb.ConTrolAppearb();
            
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
