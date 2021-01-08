using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;




public class GameControl : MonoBehaviour
{
    [SerializeField]
    public Transform[] pictures;
    //public GameObject[] pictures;

    [SerializeField]






    public bool youwin;
    public GameObject showlight;
    public GameObject lightout;
    public float angle;
    public GameObject showlight2;
    public GameObject afterlight;
    public GameObject place;
    public bool lightup;



    public GameObject elestart;



    public GameObject ss;   //把手電筒包含trigger_flashlight引進來
    public ItemDrag ww; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數

    public bool wire1_3;
    public bool wire3_3;
    public bool wire2_2;

    void check1_3()
    {
        if (pictures[1].transform.eulerAngles.z == 0 || pictures[1].transform.eulerAngles.z == 180)
        {
            wire1_3 = true;
        }
        else { wire1_3 = false;}
    }
    void check3_3()
    {
        if (pictures[7].transform.eulerAngles.z == 0 || pictures[7].transform.eulerAngles.z == 180)
        {
            wire3_3 = true;
        }
        else { wire3_3 = false;}

    }

    void check2_2()
    {
        if (pictures[3].transform.eulerAngles.z == 0 || pictures[3].transform.eulerAngles.z == 180)
        {
            wire2_2 = true;
        }
        else {  wire2_2 = false;}
    }

    void Start()
    {
        lightup = false;

        youwin = false;
        ww = ss.GetComponent<ItemDrag>();//用那個代名詞取得trigger_flashlight的所有變數
        elestart.SetActive(false);
        wire1_3 = false;
        wire3_3 = false;
        wire2_2 = false;
    }



    //void check()
    //{
    //    if (Eopen == 1) DEbug.Log("JASON");
    //}
    IEnumerator WaitBeforeShow()
    {
        if (lightup == true)
        {

            yield return new WaitForSeconds(7);
            elestart.SetActive(true);

        }

    }


    void Update()
    {
        check1_3();
        check3_3();
        check2_2();
        StartCoroutine(WaitBeforeShow());

        //if (ww.isdog == true) Debug.Log("<<<");
        angle = pictures[0].transform.eulerAngles.z;
        if (

               ww.isdog == true &&
                //  pictures[0].transform.eulerAngles.z == 0 &&
                pictures[0].transform.eulerAngles.z == 0 &&
                pictures[2].transform.eulerAngles.z == 0 &&
                wire2_2 == true &&
                pictures[4].transform.eulerAngles.z == 0 &&
                pictures[5].transform.eulerAngles.z == 0 &&
                pictures[6].transform.eulerAngles.z == 0 &&
                wire3_3 == true &&
               wire1_3 == true)
        {
            youwin = true;

            showlight.SetActive(true);//雙電流
            showlight2.SetActive(true);//雙電流
            lightup = true;


            lightout.SetActive(false);//閃爍光
            place.SetActive(false);//黑白發電室
            afterlight.SetActive(true);//通電後燈開
            Flowchart.BroadcastFungusMessage("0000");

        }
    }
}
//rotation.z