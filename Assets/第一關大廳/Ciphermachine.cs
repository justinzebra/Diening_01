using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciphermachine : MonoBehaviour
{
    public Player AA;
    BoxCollider2D bw;
    SpriteRenderer w;
    public GameObject cipher;
    
    void Start()
    {
        AA = AA.GetComponent<Player>();
        bw = GetComponent<BoxCollider2D>();
        w = GetComponent<SpriteRenderer>();
        cipher.SetActive(false);
        
    }
    public void CloseBoxCollider()
    {
        bw.enabled = false;
        w.enabled = false;
    }
    void OnMouseDown()
    {
        if (gameObject.name == "cipher")
        {
            AA.StopMove();
            cipher.SetActive(true);
            
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
