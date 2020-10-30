using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public Player AA;
    BoxCollider2D bw;
    SpriteRenderer w;
    public GameObject game;
    void Start()
    {
        AA = AA.GetComponent<Player>();
        bw = GetComponent<BoxCollider2D>();
        w = GetComponent<SpriteRenderer>();
        game.SetActive(false);
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
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
