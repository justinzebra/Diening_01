using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xrayequipment : MonoBehaviour
{
   public GameObject monitor;
    public Player AA;
    void OnMouseDown()
    {
        if(gameObject.name=="X光螢幕")
        {
            monitor.SetActive(true);
            AA.StopMove();
        }
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
    }

    // Update is called once per frame
    void Update()
    {
        CloseMonitor();
    }
}
