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
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    bool doorOpen;
    public AudioClip p;
    AudioSource audiosource;
    public opendoor opendoor;

    public void CheckDoor()
    {
        if (code[0].GetComponent<code1>().number==7&&code[1].GetComponent<code2>().number==2&&
        code[2].GetComponent<code3>().number==5&&code[3].GetComponent<code4>().number==3 &&!doorOpen) 
        {
            doorOpen = true;
            Debug.Log("對了");
            opendoor.MusicPlay();
            code1.Cantchange();
            code2.Cantchange();
            code3.Cantchange();
            code4.Cantchange();
            Destroy(c1);
            Destroy(c2);
            Destroy(c3);
            Destroy(c4);
        }else
        {
            Debug.Log("錯了");
        }
        audiosource.PlayOneShot(p);
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
        opendoor = opendoor.GetComponent<opendoor>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
