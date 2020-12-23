using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    public GameObject monitor;
    public Player AA;
    public monitormove monitormove;
    void OnMouseDown()
    {
        if(gameObject.name=="Monitor7")
        {
            monitor.SetActive(true);
            AA.StopMove();
            monitormove.monitor=monitoR.m1;
        }
        else if(gameObject.name=="Monitor2")
        {
            monitor.SetActive(true);
            AA.StopMove();
            monitormove.monitor=monitoR.m2;
        }
        else if(gameObject.name=="Monitor5")
        {
            monitor.SetActive(true);
            AA.StopMove();
            monitormove.monitor=monitoR.m3;
        }
        else if(gameObject.name=="Monitor4")
        {
            monitor.SetActive(true);
            AA.StopMove();
            monitormove.monitor=monitoR.m4;
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
        monitormove = monitormove.GetComponent<monitormove>();
        // monitormove = FindObjectOfType<monitormove>();
    }

    // Update is called once per frame
    void Update()
    {
        CloseMonitor();
    }
}
