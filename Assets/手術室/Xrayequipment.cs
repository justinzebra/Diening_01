using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xrayequipment : MonoBehaviour
{
    public GameObject monitor;
    public GameObject bonenokey;
    public GameObject bone;
    public GameObject body;
    public Player AA;
    bool m_appear = true;
    BoxCollider2D bw;
    GameManager gameManager;
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
    void checkbody()
    {
        if(Input.GetKey("up"))
        {
            gameManager.bodyisnokey=true;
        }
    }
    void bodyisnokey()
    {
        if(gameManager.bodyisnokey==true)
        {
            bone.SetActive(false);
            bonenokey.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        monitor.SetActive(false);
        AA = AA.GetComponent<Player>();
        bw = GetComponent<BoxCollider2D>();
        bonenokey.SetActive(false);
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        CloseMonitor();
        Appear();
        checkbody();
        bodyisnokey();
    }
}
