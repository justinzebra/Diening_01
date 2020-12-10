using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window : MonoBehaviour
{
    public Player AA;
    public windowa BB;
    public windowaf bb;
    public windowaback CC;
    public AudioClip Rainmusic;
    private AudioSource rain;

    void Start()
    {
        AA = AA.GetComponent<Player>();
        BB = BB.GetComponent<windowa>();
        bb = bb.GetComponent<windowaf>();
        CC = CC.GetComponent<windowaback>();
        rain = GetComponent<AudioSource>();
        rain.loop = true; 
        rain.volume = 0.3f;
        rain.clip = Rainmusic;
        rain.Play(); 
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "window")
        {
            AA.StopMove();
            BB.ConTrolAppear();
            bb.ConTrolAppearf();
            CC.ConTrolAppearb();
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
