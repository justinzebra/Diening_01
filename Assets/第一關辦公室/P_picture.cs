using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_picture : MonoBehaviour
{
    public Player AA;
    public Picturea BB;
    public picture cc0;
    public picture cc1;
    public picture cc2;
    public pictureslot CC0;
    public pictureslot CC1;
    public pictureslot CC2;
    public windowaback bb;
    public mainPicture Mb;
    BoxCollider2D bw;
    
    // Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<Player>();
        BB = BB.GetComponent<Picturea>();
        cc0 = cc0.GetComponent<picture>();
        cc1 = cc1.GetComponent<picture>();
        cc2 = cc2.GetComponent<picture>();
        CC0 = CC0.GetComponent<pictureslot>();
        CC1 = CC1.GetComponent<pictureslot>();
        CC2 = CC2.GetComponent<pictureslot>();
        bb = bb.GetComponent<windowaback>();
        Mb = Mb.GetComponent<mainPicture>();
        bw = GetComponent<BoxCollider2D>();
        
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "picture")
        {
            AA.StopMove();
            BB.ConTrolAppear();
            cc0.ConTrolAppear();
            cc1.ConTrolAppear();
            cc2.ConTrolAppear();
            CC0.ConTrolAppearbs();
            CC1.ConTrolAppearbs();
            CC2.ConTrolAppearbs();
            bb.ConTrolAppearb();
            // Mb.SavePosition();
            Mb.SavePicture();
            
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
