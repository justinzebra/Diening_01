﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciphermachine : MonoBehaviour
{
    public Player AA;
    public GameObject cipher;
    GameManager gameManager;
    BoxCollider2D bw;
    public GameObject fdoor;
    
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        AA = AA.GetComponent<Player>();
        cipher.SetActive(false);
        bw = GetComponent<BoxCollider2D>();
        fdoor.SetActive(false);
    }
    void cipherappear()
    {
        if(gameManager.cipherisopen==true)
        {
            bw.enabled=false;
            fdoor.SetActive(true);
        }
        else
        {
            bw.enabled=true;
        }
    }
    void OnMouseDown()
    {
        if (gameObject.name == "cipher")
        {
            AA.StopMove();
            cipher.SetActive(true);
        }

    }
    public void closecipher()
    {
        cipher.SetActive(false);
        AA.ReStartMove();
    }
    // Update is called once per frame
    void Update()
    {
        cipherappear();
    }
}
