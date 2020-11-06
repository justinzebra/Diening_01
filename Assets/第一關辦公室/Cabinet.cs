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
    public bookslot CC1;
    public bookslot CC2;
    public bookslot CC3;
    public bookslot CC4;
    public bookslot CC5;
    public windowaback bb;
    BoxCollider2D bw;
    SpriteRenderer w;
    public GameObject cabinet;
    void Start()
    {
        AA = AA.GetComponent<Player>();
        BB = BB.GetComponent<Cabineta>();
        cc0 = cc0.GetComponent<book>();
        cc1 = cc1.GetComponent<book>();
        cc2 = cc2.GetComponent<book>();
        cc3 = cc3.GetComponent<book>();
        cc4 = cc4.GetComponent<book>();
        CC1 = CC1.GetComponent<bookslot>();
        CC2 = CC2.GetComponent<bookslot>();
        CC3 = CC3.GetComponent<bookslot>();
        CC4 = CC4.GetComponent<bookslot>();
        CC5 = CC5.GetComponent<bookslot>();
        bb = bb.GetComponent<windowaback>();
        bw = GetComponent<BoxCollider2D>();
        w = GetComponent<SpriteRenderer>();
        cabinet.SetActive(false);
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
            CC1.ConTrolAppearbs();
            CC2.ConTrolAppearbs();
            CC3.ConTrolAppearbs();
            CC4.ConTrolAppearbs();
            CC5.ConTrolAppearbs();
            bb.ConTrolAppearb();
            cabinet.SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
