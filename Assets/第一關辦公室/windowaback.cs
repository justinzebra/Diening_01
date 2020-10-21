using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowaback : MonoBehaviour
{
    bool b_appear = false;
    public windowa BB;
    public windowaf bb;
    public Player AA;
    public Cabineta CC;
    public book cc0;
    public book cc1;
    public book cc2;
    public book cc3;
    public book cc4;
    public bookslot CC0;
    public bookslot CC1;
    public bookslot CC2;
    public bookslot CC3;
    public bookslot CC4;    
    public picture PP0;
    public picture PP1;
    public picture PP2;
    public pictureslot pp0;
    public pictureslot pp1;
    public pictureslot pp2;
    public Picturea PA;
    SpriteRenderer w;
    BoxCollider2D bw;

    public void ConTrolAppearb()
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
    void OnMouseDown()
    {
        if (gameObject.tag == "windowl")
        {
            BB.DisAppear();
            bb.DisAppear();
            CC.DisAppear();
            PA.DisAppear();
            AA.ReStartMove();
            cc0.DisAppear();
            cc1.DisAppear();
            cc2.DisAppear();
            cc3.DisAppear();
            cc4.DisAppear();
            CC0.DisAppear();
            CC1.DisAppear();
            CC2.DisAppear();
            CC3.DisAppear();
            CC4.DisAppear();
            PP0.DisAppear();
            PP1.DisAppear();
            PP2.DisAppear();
            pp0.DisAppear();
            pp1.DisAppear();
            pp2.DisAppear();
            b_appear = false;
            
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<Player>();
        BB = BB.GetComponent<windowa>();
        bb = bb.GetComponent<windowaf>();

        CC = CC.GetComponent<Cabineta>();
        cc0 = cc0.GetComponent<book>();
        cc1 = cc1.GetComponent<book>();
        cc2 = cc2.GetComponent<book>();
        cc3 = cc3.GetComponent<book>();
        cc4 = cc4.GetComponent<book>();
        CC0 = CC0.GetComponent<bookslot>();
        CC1 = CC1.GetComponent<bookslot>();
        CC2 = CC2.GetComponent<bookslot>();
        CC3 = CC3.GetComponent<bookslot>();
        CC4 = CC4.GetComponent<bookslot>();

        PP0 = PP0.GetComponent<picture>();
        PP1 = PP1.GetComponent<picture>();
        PP2 = PP2.GetComponent<picture>();
        pp0 = pp0.GetComponent<pictureslot>();
        pp1 = pp1.GetComponent<pictureslot>();
        pp2 = pp2.GetComponent<pictureslot>();
        PA = PA.GetComponent<Picturea>();

        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
