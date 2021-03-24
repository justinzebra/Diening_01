﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    GameManager gameManager;
    public GameObject player;
    private string sceneName;
    void Lobby()
    {
        if(sceneName=="Lobby")
        {
        if(gameManager.currents==currentS.AtoL)
        {
            player.gameObject.transform.position = new Vector3(-53.73f,1.11f,-1.1f);
        }
        else if(gameManager.currents==currentS.SRtoL)
        {
            player.gameObject.transform.position = new Vector3(46.7f,1.11f,-1.1f);
        }
        }
    }
    void Securityroom()
    {
        if(sceneName=="Securityroom")
        {
        if(gameManager.currents==currentS.LtoSR)
        {
            player.gameObject.transform.position = new Vector3(27.56f,-1.069f,-1.1f);
        }
        }
    }
    void gallery_after()
    {
        if(sceneName=="gallery_after")
        {
        if(gameManager.currents==currentS.EtoA)
        {
            player.gameObject.transform.position = new Vector3(35.8f,8.07f,-1.1f);
        }
        else if(gameManager.currents==currentS.LtoA)
        {
            player.gameObject.transform.position = new Vector3(19f,8.07f,-1.1f);
        }
        else if(gameManager.currents==currentS.StoA)
        {
            player.gameObject.transform.position = new Vector3(-11.14f,8.07f,-1.1f);
        }
        }
    }
    void surgery()
    {
        if(sceneName=="surgery")
        {
        if(gameManager.currents==currentS.AtoS)
        {
            player.gameObject.transform.position = new Vector3(26.93f,-4.64f,-1.5f);
        }
        }
    }
    void gallery_before()
    {
        if(sceneName=="gallery_before")
        {
        if(gameManager.currents==currentS.EtoB)
        {
            player.gameObject.transform.position = new Vector3(35.47649f,8.130759f,-1.1f);
            gameManager.dogisgoout=true;
        }
        }
    }
    void Pharmacyroom()
    {
        if(sceneName=="Pharmacyroom")
        {
        if(gameManager.currents==currentS.eGtoP)
        {
            player.gameObject.transform.position = new Vector3(15f,3.01721f,-1.1f);
        }
        }
    }
    void gallery_firstfloor()
    {
        if(sceneName=="gallery_firstfloor")
        {
            if(gameManager.currents==currentS.PtoeG)
            {
                player.gameObject.transform.position = new Vector3(-50.31f,8.81f,-1f);
            }
            else if(gameManager.currents==currentS.b1GtoeG)
            {
                player.gameObject.transform.position = new Vector3(9.67f,8.81f,-1f);
            }
            else if(gameManager.currents==currentS.LtoeG)
            {
                player.gameObject.transform.position = new Vector3(-92.3f,8.81f,-1f);
            }
            else if(gameManager.currents==currentS.inEtoeG)
            {
                player.gameObject.transform.position = new Vector3(-25.78f,8.81f,-1f);
            }
        }
    }
    void gallery_B1()
    {
        if(sceneName=="gallery_B1")
        {
            if(gameManager.currents==currentS.eGtob1G)
            {
                player.gameObject.transform.position = new Vector3(-6.16f,8.05f,-1.1f);
            }
            else if(gameManager.currents==currentS.Itob1G)
            {
                player.gameObject.transform.position = new Vector3(-22.1f,8.05f,-1.1f);
            }
        }
    }
    void incineration()
    {
        if(sceneName=="incineration")
        {
        if(gameManager.currents==currentS.b1GtoI)
        {
            player.gameObject.transform.position = new Vector3(7.4f,8.05f,-0.4f);
        }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        sceneName = SceneManager.GetActiveScene().name;
        Lobby();
        Securityroom();
        gallery_after();
        surgery();
        gallery_before();
        Pharmacyroom();
        gallery_firstfloor();
        gallery_B1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
