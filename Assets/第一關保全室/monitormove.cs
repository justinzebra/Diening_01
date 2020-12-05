using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum monitor
    {
        m1,
        m2,
        m3,
        m4
    }

public class monitormove : MonoBehaviour
{
    RectTransform Rect;
    public monitor monitor;
    void Move()
    {
        if(monitor==monitor.m1)
        {
            Rect.anchoredPosition=new Vector2(0,0);
        }
        else if(monitor==monitor.m2)
        {
            Rect.anchoredPosition=new Vector2(-480,0);
        }
        else if(monitor==monitor.m3)
        {
            Rect.anchoredPosition=new Vector2(-950,0);
        }
        else if(monitor==monitor.m4)
        {
            Rect.anchoredPosition=new Vector2(-1430,0);
        }
    }
    void Changemonitor()
    {
        if (Input.GetKey("c"))
        {
            monitor=monitor.m1;
        }
        else if(Input.GetKey("v"))
        {
            monitor=monitor.m2;
        }
        else if(Input.GetKey("b"))
        {
            monitor=monitor.m3;
        }
        else if(Input.GetKey("n"))
        {
            monitor=monitor.m4;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Rect=GetComponent<RectTransform>();
        monitor=monitor.m1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Changemonitor();
    }
}
