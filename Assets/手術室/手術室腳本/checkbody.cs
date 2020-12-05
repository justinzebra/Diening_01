using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkbody : MonoBehaviour
{
    public GameObject body;
    public GameObject bodyisopen;
    GameManager gameManager;
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
    }
    void Update()
    {
        Checkbody();
    }
}
