using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public Player AA;
    BoxCollider2D bw;
    SpriteRenderer w;
    public GameObject game;
    public windowaback cb;
    void Start()
    {
        AA = AA.GetComponent<Player>();
        bw = GetComponent<BoxCollider2D>();
        w = GetComponent<SpriteRenderer>();
        game.SetActive(false);
        cb = cb.GetComponent<windowaback>();
    }
    public void CloseBoxCollider()
    {
        bw.enabled = false;
        w.enabled = false;
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "computer")
        {
            AA.StopMove();
            game.SetActive(true);
            cb.ConTrolAppearb();
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
