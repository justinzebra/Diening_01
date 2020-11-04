using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class mainBook : MonoBehaviour
{
    public Vector3[] bookPos;
    public book[] allBook = new book[5];
    public Transform[] Book;
    public opendoor AA;
    public Cabinet CC;
    bool doorOpen;


    public void SavePosition()
    {
        bookPos = new Vector3[5];
        for (int i = 0; i < transform.childCount; i++)
        {

            bookPos[i] = transform.GetChild(i).transform.position;

        }
    }
    public void SaveBook()
    {
        allBook = GetComponentsInChildren<book>();
    }
    void CheckDoor()
    {
        if (Book[0].GetComponent<book>().id == 1 &&
           Book[1].GetComponent<book>().id == 3 &&
           Book[2].GetComponent<book>().id == 0 &&
           Book[3].GetComponent<book>().id == 2 &&
           Book[4].GetComponent<book>().id == 4 && !doorOpen) 
        {
            doorOpen = true;
            Invoke("Opendoor",4);
        }
    }
    public void Opendoor()
    {
         AA.MusicPlay();
         CC.CloseBoxCollider();
    }
    //Start is called before the first frame update
    void Start()
    {
        AA = AA.GetComponent<opendoor>();
        CC = CC.GetComponent<Cabinet>();
        doorOpen=false;

    }

    // Update is called once per frame
    void Update()
    {
        CheckDoor();

    }
}
