using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code4 : MonoBehaviour
{
  public int number;
    public Text num;
    public bool C4=false;
    public AudioClip p;
    AudioSource audiosource;
    public void Canchange()
    {
        C4=true;
    }
    public void Cantchange()
    {
        C4=false;
    }
    public void Number0()
    {
        num.text=" ";
    }
    public void Inputnumber1()
    {
        if(C4==true)
        {
        number = 1;
        num.text=number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber2()
    {
        if(C4==true)
        {
        number = 2;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber3()
    {
        if(C4==true)
        {
        number = 3;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber4()
    {
        if(C4==true)
        {
        number = 4;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber5()
    {
        if(C4==true)
        {
        number = 5;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber6()
    {
        if(C4==true)
        {
        number = 6;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber7()
    {
        if(C4==true)
        {
        number = 7;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber8()
    {
        if(C4==true)
        {
        number = 8;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber9()
    {
        if(C4==true)
        {
        number = 9;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
        }
    }
    public void Inputnumber0()
    {
        if(C4==true)
        {
        number = 0;
        num.text = number.ToString();
        audiosource.PlayOneShot(p);
        Cantchange();
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
