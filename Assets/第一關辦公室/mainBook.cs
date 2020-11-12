using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using Fungus;


public class mainBook : MonoBehaviour
{
    public opendoor AA;
    public Cabinet CC;
    bool doorOpen;
    bool D = false;
    bool F = false;
    bool J = false;
    bool L = false;
    bool P = false;
    public windowaback windowaback;


    void CheckDoor()
    {
        if (D == true && F == true && J == true && L == true && P == true && !doorOpen)
        {
            doorOpen = true;
            Opendoor();
            Invoke("closeCabinet", 3);
            Flowchart.BroadcastFungusMessage("98765");
        }
    }
    public void isD()
    {
        D = true;
    }
    public void notD()
    {
        D = false;
    }
    public void isF()
    {
        F = true;
    }
    public void notF()
    {
        F = false;
    }
    public void isJ()
    {
        J = true;
    }
    public void notJ()
    {
        J = false;
    }
    public void isL()
    {
        L = true;
    }
    public void notL()
    {
        L = false;
    }
    public void isP()
    {
        P = true;
    }
    public void notP()
    {
        P = false;
    }
    public void Opendoor()
    {
        AA.MusicPlay();
        CC.CloseBoxCollider();
    }
    void closeCabinet()
    {
        windowaback.OnMouseDown();
    }
    //Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<opendoor>();
        CC = CC.GetComponent<Cabinet>();
        windowaback = windowaback.GetComponent<windowaback>();
        doorOpen = false;

    }

    // Update is called once per frame
    void Update()
    {
        CheckDoor();

    }
}
