using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perspective : MonoBehaviour
{
    public GameObject c1;
    public GameObject c2;
    public Player AA;
    void ChangeFollow1()
    {
        if(Input.GetKey(KeyCode.C))
        {
            c1.SetActive(false);
            Invoke("Changefollow1",0.1f);
            AA.StopMove();
        }
    }
    void ChangeFollow2()
    {
        if(Input.GetKey(KeyCode.K))
        {
            c2.SetActive(false);
            Invoke("Changefollow2",0.1f);
            AA.ReStartMove();
        }
    }
    void Changefollow1()
    {
        c2.SetActive(true);
    }
    void Changefollow2()
    {
        c1.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        c2.SetActive(false);
        AA = AA.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeFollow1();
        ChangeFollow2();
    }
}
