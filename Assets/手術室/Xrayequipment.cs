using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xrayequipment : MonoBehaviour
{
    public GameObject monitor;
    public Player AA;
    bool m_appear = true;
    BoxCollider2D bw;
    void OnMouseDown()
    {
        if(gameObject.name=="X光螢幕")
        {
            monitor.SetActive(true);
            AA.StopMove();
            CloseBoxCollider();
        }
    }
    void Appear()
    {
        if (m_appear == true)
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
       m_appear = false;
    }
    public void OpenBoxCollider()
    {
       m_appear = true;
    }
    void CloseMonitor()
    {
        if(Input.GetKey(KeyCode.H))
        {
            AA.ReStartMove();
            monitor.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        monitor.SetActive(false);
        AA = AA.GetComponent<Player>();
        bw = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CloseMonitor();
        Appear();
    }
}
