using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    public GameObject monitor;
    public Player AA;
    void OnMouseDown()
    {
        if(gameObject.name=="電腦")
        {
            monitor.SetActive(true);
            AA.StopMove();
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
    }

    // Update is called once per frame
    void Update()
    {
        CloseMonitor();
    }
}
