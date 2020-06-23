using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Touch : MonoBehaviour
{
    public GameObject ss;   //把手電筒包含trigger_flashlight引進來
    public GameControl ww; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數

    void Start()
    {
        
        ww = ss.GetComponent<GameControl>();//用那個代名詞取得trigger_flashlight的所有變數

    }

    //public GameObject soundobject;
    private void OnMouseDown()
    {
        if (ww.youwin == false)
        { 
        transform.Rotate(0f, 0f, 90f);
        //Instantiate(soundobject, transform.position, Quaternion.identity);
        GetComponent<AudioSource>().Play();

    }
    }



}






