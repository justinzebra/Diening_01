using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciphermachine : MonoBehaviour
{
    public Player AA;
    BoxCollider2D bw;
    public GameObject cipher;
    bool c_appear = true;
    
    void Start()
    {
        AA = AA.GetComponent<Player>();
        bw = GetComponent<BoxCollider2D>();
        cipher.SetActive(false);
    }
     void Appear()
    {
        if (c_appear == true)
        {
            bw.enabled = true;
        }
        else
        {
            bw.enabled = false;
        }
    }
    public void CloseBoxCollider()
    {
       c_appear = false;
    }
    public void OpenBoxCollider()
    {
       c_appear = true;
    }
    void OnMouseDown()
    {
        if (gameObject.name == "cipher")
        {
            AA.StopMove();
            cipher.SetActive(true);
            CloseBoxCollider();
        }

    }
    // Update is called once per frame
    void Update()
    {
        Appear();
    }
}
