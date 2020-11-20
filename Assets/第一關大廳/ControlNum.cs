using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNum : MonoBehaviour
{
    public code1 code1;
    public code2 code2;
    public code3 code3;
    public code4 code4;
    void OnMouseDown()
    {
        if(gameObject.name=="C1")
        {
            code1.Canchange();
            code2.Cantchange();
            code3.Cantchange();
            code4.Cantchange();
        }
        else if(gameObject.name=="C2")
        {
            code2.Canchange();
            code1.Cantchange();
            code3.Cantchange();
            code4.Cantchange();
        }
        else if(gameObject.name=="C3")
        {
            code3.Canchange();
            code1.Cantchange();
            code2.Cantchange();
            code4.Cantchange();
        }
        else if(gameObject.name=="C4")
        {
            code4.Canchange();
            code1.Cantchange();
            code2.Cantchange();
            code3.Cantchange();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        code1 = code1.GetComponent<code1>();
        code2 = code2.GetComponent<code2>();
        code3 = code3.GetComponent<code3>();
        code4 = code4.GetComponent<code4>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
