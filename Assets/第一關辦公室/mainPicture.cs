using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class mainPicture : MonoBehaviour
{
    public Vector3[] picturePos;
    public picture[] allPicture = new picture[3];
    public Transform[] Picture;
    public picture2 pp0;
    public picture2 pp1;
    public picture2 pp2;
    public heartpicture hp;
    bool ispicture;
    public GameObject picture;
    public GameObject picture0;
    public GameObject picture1;
    public GameObject picture2;
    public void SavePosition()
    {
        picturePos = new Vector3[3];
        for (int i = 0; i < transform.childCount; i++)
        {

            picturePos[i] = transform.GetChild(i).position;

        }
    }
    public void SavePicture()
    {
        allPicture = GetComponentsInChildren<picture>();
    }
    void CheckPicture()
    {
        if (Picture[0].GetComponent<picture>().id == 1 &&
           Picture[1].GetComponent<picture>().id == 2 &&
           Picture[2].GetComponent<picture>().id == 0 &&!ispicture
           ) 
        {
           ispicture=true;
           Debug.Log("5555");
           Invoke("ConTrol",2);
        }
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
