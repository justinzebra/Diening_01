using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class mainPicture : MonoBehaviour
{
    public Vector3[] picturePos;
    public picture[] allPicture = new picture[3];
    public Transform[] Picture;
    // public opendoor AA;
    public pictureslot BB0;
    public pictureslot BB1;
    public pictureslot BB2;
    public picture bb0;
    public picture bb1;
    public picture bb2;
    bool ispicture;
    public GameObject picture;
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
        //    BB0.D_Appear();
        //    BB1.D_Appear();
        //    BB2.D_Appear();
        //    bb0.D_Appear();
        //    bb1.D_Appear();
        //    bb2.D_Appear();
           Destroy(picture);
        }
    }

    //Start is called before the first frame update
    void Start()
    {
        ispicture=false;
        BB0 = BB0.GetComponent<pictureslot>();
        BB1 = BB1.GetComponent<pictureslot>();
        BB2 = BB2.GetComponent<pictureslot>();
        bb0 = bb0.GetComponent<picture>();
        bb1 = bb1.GetComponent<picture>();
        bb2 = bb2.GetComponent<picture>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckPicture();
    }
}
