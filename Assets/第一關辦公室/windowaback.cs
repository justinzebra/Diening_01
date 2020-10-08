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
            AA.ReStartMove();
            cc0.DisAppear();
            cc1.DisAppear();
            cc2.DisAppear();
            cc3.DisAppear();
            cc4.DisAppear();
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
        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
