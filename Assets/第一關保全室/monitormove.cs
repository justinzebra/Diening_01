using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public enum monitoR
    {
        m1,
        m2,
        m3,
        m4
    }

public class monitormove : MonoBehaviour
{
    RectTransform Rect;
    public monitoR monitor;
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
        if(monitor==monitoR.m1)
        {
            monitor=monitoR.m2;
        }
        else if(monitor==monitoR.m2)
        {
            monitor=monitoR.m3;
        }
        else if(monitor==monitoR.m3)
        {
            monitor=monitoR.m4;
        }
    }
    public void Moveleft()
    {
        if(monitor==monitoR.m4)
        {
            monitor=monitoR.m3;
        }
        else if(monitor==monitoR.m3)
        {
            monitor=monitoR.m2;
        }
        else if(monitor==monitoR.m2)
        {
            monitor=monitoR.m1;
        }
    }
    void Changemonitor()
    {
        if (monitor==monitoR.m1)
        {
            m_pos=0;
            Rect.anchoredPosition=new Vector2(m_pos,0);
        }
        else if(monitor==monitoR.m2)
        {
            m_pos=-480;
            Rect.anchoredPosition=new Vector2(m_pos,0);
        }
        else if(monitor==monitoR.m3)
        {
            m_pos=-960;
            Rect.anchoredPosition=new Vector2(m_pos,0);
        }
        else if(monitor==monitoR.m4)
        {
            m_pos=-1440;
            Rect.anchoredPosition=new Vector2(m_pos,0);
        }
    }
    public void vediosouce1()
    {
        Flowchart.BroadcastFungusMessage("guard1");
    }
    public void vediosouce2()
    {
        Flowchart.BroadcastFungusMessage("guard2");
    }
    public void vediosouce3()
    {
        Flowchart.BroadcastFungusMessage("guard3");
    }
    public void vediosouce4()
    {
        Flowchart.BroadcastFungusMessage("guard4");
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
        Changemonitor();
        // Move();
    }
}
