using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCode : MonoBehaviour
{
    public Transform[] code;
    public code1 code1;
    public code2 code2;
    public code3 code3;
    public code4 code4;
    public GameObject cipher;
    bool doorOpen;
    public AudioClip p;
    AudioSource audiosource;
    public L_opendoor opendoor;

    public void CheckDoor()
    {
        if (code[0].GetComponent<code1>().number==7&&code[1].GetComponent<code2>().number==2&&
        code[2].GetComponent<code3>().number==5&&code[3].GetComponent<code4>().number==4 &&!doorOpen) 
        {
            doorOpen = true;
            Debug.Log("對了");
            opendoor.MusicPlay();
            code1.Cantchange();
            code2.Cantchange();
            code3.Cantchange();
            code4.Cantchange();
            Destroy(cipher);

        }else
        {
            Debug.Log("錯了");
            opendoor.rongMusic();
            Invoke("Clearallnumber",1f);
        }
        // audiosource.PlayOneShot(p);
    }
    public void Clearallnumber()
    {
        code1.Canchange();
        code2.Cantchange();
        code3.Cantchange();
        code4.Cantchange();
        code1.Number0();
        code2.Number0();
        code3.Number0();
        code4.Number0();
    }
    public void Clearnumber()
    {
        code1.Canchange();
        code2.Cantchange();
        code3.Cantchange();
        code4.Cantchange();
        code1.Number0();
        code2.Number0();
        code3.Number0();
        code4.Number0();
        audiosource.PlayOneShot(p);
    }
    // Start is called before the first frame update
    void Start()
    {
        doorOpen=false;
        code1 = code1.GetComponent<code1>();
        code2 = code2.GetComponent<code2>();
        code3 = code3.GetComponent<code3>();
        code4 = code4.GetComponent<code4>();
        audiosource = GetComponent<AudioSource>();
        opendoor = opendoor.GetComponent<L_opendoor>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
