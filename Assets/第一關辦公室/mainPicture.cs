using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class mainPicture : MonoBehaviour
{
    public picture2 pp0;
    public picture2 pp1;
    public picture2 pp2;
    public heartpicture hp;
    bool ispicture;
    bool brain=false;
    bool heart=false;
    bool lung=false;
    public GameObject picture;
    public GameObject picture0;
    public GameObject picture1;
    public GameObject picture2;
    void CheckPicture()
    {
         if (brain==true&&heart==true&&lung==true&&!ispicture) 
        {
           ispicture=true;
           Debug.Log("5555");
           ConTrol();
        //    Invoke("ConTrol",2);
        }
    }
    public void isBrain()
    {
        brain=true;
    }
    public void notBrain()
    {
        brain=false;
    }
    public void isHeart()
    {
        heart=true;
    }
    public void notHeart()
    {
        heart=false;
    }
    public void isLung()
    {
        lung=true;
    }
    public void notLung()
    {
        lung=false;
    }
    void ConTrol()
    {
           picture.SetActive(false);
           picture0.SetActive(false);
           picture1.SetActive(false);
           picture2.SetActive(false);
           pp0.ConTrolAppear();
           pp1.ConTrolAppear();
           pp2.ConTrolAppear();
           hp.ConTrolAppear();
    }

    //Start is called before the first frame update
    void Start()
    {
        ispicture=false;
        pp0 = pp0.GetComponent<picture2>();
        pp1 = pp1.GetComponent<picture2>();
        pp2 = pp2.GetComponent<picture2>();
        hp = hp.GetComponent<heartpicture>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckPicture();
    }
}
