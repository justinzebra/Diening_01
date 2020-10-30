using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabinet : MonoBehaviour
{
    public Player AA;
    public Cabineta BB;
    public book cc0;
    public book cc1;
    public book cc2;
    public book cc3;
    public book cc4;
    public bookslot CC;
    public windowaback bb;
    public mainBook Mb;
    BoxCollider2D bw;
    SpriteRenderer w;
    void Start()
    {
        AA = AA.GetComponent<Player>();
        BB = BB.GetComponent<Cabineta>();
        cc0 = cc0.GetComponent<book>();
        cc1 = cc1.GetComponent<book>();
        cc2 = cc2.GetComponent<book>();
        cc3 = cc3.GetComponent<book>();
        cc4 = cc4.GetComponent<book>();
        CC = CC.GetComponent<bookslot>();
        bb = bb.GetComponent<windowaback>();
        Mb = Mb.GetComponent<mainBook>();
        bw = GetComponent<BoxCollider2D>();
        w = GetComponent<SpriteRenderer>();
    }
    public void CloseBoxCollider()
    {
        bw.enabled = false;
        w.enabled = false;
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "cabinet")
        {
            AA.StopMove();
            BB.ConTrolAppear();
            cc0.BConTrolAppear();
            cc1.BConTrolAppear();
            cc2.BConTrolAppear();
            cc3.BConTrolAppear();
            cc4.BConTrolAppear();
            CC.ConTrolAppearbs();
            bb.ConTrolAppearb();
            // Mb.SavePosition();
            Mb.SaveBook();
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
