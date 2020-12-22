using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    public GameObject monitor;
    public Player AA;
    monitormove monitormove;
    void OnMouseDown()
    {
        if(gameObject.name=="Monitor7")
        {
            monitor.SetActive(true);
            AA.StopMove();
            // monitormove.monitor=monitor.m1;
        }
        else if(gameObject.name=="Monitor2")
        {
            monitor.SetActive(true);
            AA.StopMove();
            // monitormove.monitor=monitor.m2;
        }
        else if(gameObject.name=="Monitor5")
        {
            monitor.SetActive(true);
            AA.StopMove();
            // monitormove.monitor=monitor.m3;
        }
        else if(gameObject.name=="Monitor4")
        {
            monitor.SetActive(true);
            AA.StopMove();
            // monitormove.monitor=monitor.m4;
        }
    }
    void CloseMonitor()
    {
        if(Input.GetKey(KeyCode.M))
        {
            monitor.SetActive(false);
            AA.ReStartMove();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        monitor.SetActive(false);
        AA = AA.GetComponent<Player>();
        monitormove = FindObjectOfType<monitormove>();
    }

    // Update is called once per frame
    void Update()
    {
        CloseMonitor();
    }
}
