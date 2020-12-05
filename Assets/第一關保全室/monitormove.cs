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
    public float m_pos;
    // void Move()
    // {
    //     if(monitor==monitor.m1)
    //     {
    //         Rect.anchoredPosition=new Vector2(0,0);
    //     }
    //     else if(monitor==monitor.m2)
    //     {
    //         Rect.anchoredPosition=new Vector2(-480,0);
    //     }
    //     else if(monitor==monitor.m3)
    //     {
    //         Rect.anchoredPosition=new Vector2(-950,0);
    //     }
    //     else if(monitor==monitor.m4)
    //     {
    //         Rect.anchoredPosition=new Vector2(-1430,0);
    //     }
    // }
    public void Moveright()
    {
        if(m_pos>-1430)
        {
            m_pos=m_pos-480;
        }
        Rect.anchoredPosition=new Vector2(m_pos,0);
    }
    public void Moveleft()
    {
        if(m_pos<0)
        {
            m_pos=m_pos+480;
        }
        Rect.anchoredPosition=new Vector2(m_pos,0);
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
        // monitor=monitor.m1;
        m_pos=0;
    }

    // Update is called once per frame
    void Update()
    {
        // Changemonitor();
        // Move();
    }
}
