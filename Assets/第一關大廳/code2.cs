﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code2 : MonoBehaviour
{
    public int number;
    public Text num;
    public bool C2=false;
    public AudioClip p;
    AudioSource audiosource;
    public void Canchange()
    {
        C2=true;
    }
    public void Cantchange()
    {
        C2=false;
    }
    public void Inputnumber1()
    {
        if(C2==true)
        {
        number = 1;
        num.text=number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber2()
    {
        if(C2==true)
        {
        number = 2;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber3()
    {
        if(C2==true)
        {
        number = 3;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber4()
    {
        if(C2==true)
        {
        number = 4;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber5()
    {
        if(C2==true)
        {
        number = 5;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber6()
    {
        if(C2==true)
        {
        number = 6;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber7()
    {
        if(C2==true)
        {
        number = 7;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber8()
    {
        if(C2==true)
        {
        number = 8;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber9()
    {
        if(C2==true)
        {
        number = 9;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    public void Inputnumber0()
    {
        if(C2==true)
        {
        number = 0;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
