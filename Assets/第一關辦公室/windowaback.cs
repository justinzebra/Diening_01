﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowaback : MonoBehaviour
{
    bool b_appear = false;
    public windowa BB;
    public windowaf bb;
    public Player AA;
    public Cabineta CC;
    public picture PP0;
    public picture PP1;
    public picture PP2;
    public pictureslot pp0;
    public pictureslot pp1;
    public pictureslot pp2;
    public Picturea PA;
    public picture2 P0;
    public picture2 P1;
    public picture2 P2;
    public heartpicture hp;
    public GameObject computer; 
    public GameObject socket; 
    public GameObject cabinet;

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
    public void OnMouseDown()
    {
        if (gameObject.tag == "windowl")
        {
            BB.DisAppear();
            bb.DisAppear();
            CC.DisAppear();
            PA.DisAppear();
            AA.ReStartMove();
            PP0.DisAppear();
            PP1.DisAppear();
            PP2.DisAppear();
            pp0.DisAppear();
            pp1.DisAppear();
            pp2.DisAppear();
            P0.DisAppear();
            P1.DisAppear();
            P2.DisAppear();
            hp.DisAppear();
            b_appear = false;
            computer.SetActive(false);
            socket.SetActive(false);
            cabinet.SetActive(false);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<Player>();
        BB = BB.GetComponent<windowa>();
        bb = bb.GetComponent<windowaf>();

        CC = CC.GetComponent<Cabineta>();

        PP0 = PP0.GetComponent<picture>();
        PP1 = PP1.GetComponent<picture>();
        PP2 = PP2.GetComponent<picture>();
        pp0 = pp0.GetComponent<pictureslot>();
        pp1 = pp1.GetComponent<pictureslot>();
        pp2 = pp2.GetComponent<pictureslot>();
        PA = PA.GetComponent<Picturea>();
        P0 = P0.GetComponent<picture2>();
        P1 = P1.GetComponent<picture2>();
        P2 = P2.GetComponent<picture2>();
        hp = hp.GetComponent<heartpicture>();

        w = GetComponent<SpriteRenderer>();
        bw = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
