using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkbody : MonoBehaviour
{
    public GameObject body;
    public GameObject bodyisopen;
    GameManager gameManager;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    void Checkbody()
    {
        if(gameManager.bodyisnokey==true)
        {
            Destroy(body);
            bodyisopen.SetActive(true);
        }
    }
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if(gameManager.bodyisnokey==true)
        {
            Destroy(b1);
            Destroy(b2);
            Destroy(b3);
            Destroy(b4);
            Destroy(b5);
            Destroy(b6);
            Destroy(b7);
            b8.SetActive(true);
            Destroy(b9);
        }
    }
    void Update()
    {
        Checkbody();
    }
}
