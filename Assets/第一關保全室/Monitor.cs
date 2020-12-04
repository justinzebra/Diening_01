using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    public GameObject monitor;
    public Player AA;
    public GameObject c2;
    void OnMouseDown()
    {
        if(gameObject.name=="Monitor")
        {
            monitor.SetActive(true);
            AA.StopMove();
            c2.SetActive(true);
        }
    }
    void CloseMonitor()
    {
        if(Input.GetKey(KeyCode.M))
        {
            monitor.SetActive(false);
            AA.ReStartMove();
            c2.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        monitor.SetActive(false);
        AA = AA.GetComponent<Player>();
        c2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CloseMonitor();
    }
}
