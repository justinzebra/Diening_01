using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code1 : MonoBehaviour
{
    public int number;
    // public InputField n;
    public Text num;
    public bool C1;
    public AudioClip p;
    AudioSource audiosource;
    public code2 code2;
    public void Canchange()
    {
        C1=true;
    }
    public void Cantchange()
    {
        C1=false;
    }
    void Code2()
    {
        code2.Canchange();
    }
    public void Number0()
    {
        num.text=" ";
    }
    public void Inputnumber1()
    {
        if(C1==true)
        {
        number = 1;
        num.text=number.ToString();
        // n.text=number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber2()
    {
        if(C1==true)
        {
        number = 2;
        num.text = number.ToString();
        // n.text=number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber3()
    {
        if(C1==true)
        {
        number = 3;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber4()
    {
        if(C1==true)
        {
        number = 4;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber5()
    {
        if(C1==true)
        {
        number = 5;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber6()
    {
        if(C1==true)
        {
        number = 6;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber7()
    {
        if(C1==true)
        {
        number = 7;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber8()
    {
        if(C1==true)
        {
        number = 8;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber9()
    {
        if(C1==true)
        {
        number = 9;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    public void Inputnumber0()
    {
        if(C1==true)
        {
        number = 0;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        Invoke("Code2",0.1f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        C1=true;
        code2 = code2.GetComponent<code2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
