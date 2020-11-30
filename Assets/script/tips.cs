using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tips : MonoBehaviour
{



    public GameObject ss;   //把手電筒包含trigger_flashlight引進來
    public GameControl ww; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數
    //private Collider2D other;

    //private void Start()
    //{
    //    this.gameObject.SetActive(false);

    //}
    public GameObject aa;
    public bool isdoor=false;
    public GameObject door;
    public GameObject doorB;


 
    

    void Start()
    {
        aa.SetActive(false);
        door.SetActive(false);
        doorB.SetActive(false);
        ww = ss.GetComponent<GameControl>();
     
       
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            aa.SetActive(true);
            isdoor = true;
          
        }
    }

   

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "player")
        {
            aa.SetActive(false);
            isdoor = false;
        }
    }
 
    
    void GG()
    {
        if (isdoor && !ww.lightup)
        {
            if (Input.GetKey(KeyCode.E))
            {
                door.SetActive(true);
            }
        }
        else if (/*Input.GetKey(KeyCode.B*/isdoor && ww.lightup)
        {
            {

                if (Input.GetKey(KeyCode.E))
                    doorB.SetActive(true);
            }
        }
    }

    void Update()
    {
        //OnTriggerEnter2D(other);
        //OnTriggerExit2D(other);
     
        GG();
    }

}

