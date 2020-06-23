using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wireshow : MonoBehaviour
{
    public GameObject item1;
    public GameObject itemcheck;
   

    public GameObject livedog;
    public GameObject deaddog;
    public int itemstate = 0;
    public void Show()
    {
        if (ww.Eopen == 1 && itemstate == 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                //Instantiate(soundobject, transform.position, Quaternion.identity);


                ww.Eopen = 0;
                Debug.Log("III");
                item1.SetActive(true);
                itemcheck.SetActive(false);
                itemstate = 1;
                livedog.SetActive(false);
                deaddog.SetActive(true);
            }
        }


        //Instantiate(Modeobject, transform.position, Quaternion.identity);

        else if (itemstate == 1)
        {



            if (Input.GetKeyDown(KeyCode.E))
            {
                item1.SetActive(false);

                ww.Eopen = 1;
                itemstate = 0;
                Debug.Log("XXXX");
               ww.Eopen = 0;
                itemcheck.SetActive(true);
                livedog.SetActive(true);
                deaddog.SetActive(false);
            }
        }
    }

    public void Judgeisdog()
    {
        if (JJ.isdog)
        {
            livedog.SetActive(false);
        }
    }

    public GameObject BBBB;   //把手電筒包含trigger_flashlight引進來
    public GameControl AAAA; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數




    public void CheckLightUp()
    {
        if (AAAA.lightup) {
            livedog.SetActive(false);
        }
    }




    public GameObject ss;   //把手電筒包含trigger_flashlight引進來
    public E ww; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數

    public GameObject sss;   //把手電筒包含trigger_note引進來
                             //public E www; //新增一個trigger_note的代名詞去取得其他腳本的變數


    public GameObject MM;   //拿itemdrag狗被綁上去的變數
    public ItemDrag JJ; //

    void Start()
    {
        item1.SetActive(false);
        livedog.SetActive(true);
        deaddog.SetActive(false);
        AAAA = BBBB.GetComponent<GameControl>();





        ww = ss.GetComponent<E>();//用那個代名詞取得trigger_flashlight的所有變數
        //www = sss.GetComponent<E>();//用那個代名詞取得trigger_note的所有變數
    }


    void Update()
    {
        Show();
        CheckLightUp();
    }
}

