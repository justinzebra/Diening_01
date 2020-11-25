using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code3 : MonoBehaviour
{
   public int number;
    public Text num;
    public bool C3=false;
    public AudioClip p;
    AudioSource audiosource;
    public code4 code4;
    public void Canchange()
    {
        C3=true;
    }
    public void Cantchange()
    {
        C3=false;
    }
    void Code4()
    {
        code4.Canchange();
    }
    public void Number0()
    {
        num.text=" ";
    }
    public void Inputnumber1()
    {
        if(C3==true)
        {
        number = 1;
        num.text=number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber2()
    {
        if(C3==true)
        {
        number = 2;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber3()
    {
        if(C3==true)
        {
        number = 3;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber4()
    {
        if(C3==true)
        {
        number = 4;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber5()
    {
        if(C3==true)
        {
        number = 5;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber6()
    {
        if(C3==true)
        {
        number = 6;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber7()
    {
        if(C3==true)
        {
        number = 7;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber8()
    {
        if(C3==true)
        {
        number = 8;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber9()
    {
        if(C3==true)
        {
        number = 9;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    public void Inputnumber0()
    {
        if(C3==true)
        {
        number = 0;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code4",0.1f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        code4 = code4.GetComponent<code4>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
