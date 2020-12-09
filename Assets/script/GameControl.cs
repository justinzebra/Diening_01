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
    public float angle ;
    public GameObject showlight2;
    public GameObject afterlight;
    public GameObject place;
    public bool lightup;



    public GameObject elestart;



    public GameObject ss;   //把手電筒包含trigger_flashlight引進來
    public ItemDrag ww; //新增一個trigger_flashlight的代名詞去取得其他腳本的變數


  
    

    






    void Start()
    {
        lightup = false;
       
        youwin = false;
        ww = ss.GetComponent<ItemDrag>();//用那個代名詞取得trigger_flashlight的所有變數
        elestart.SetActive(false);
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
        StartCoroutine(WaitBeforeShow());

        //if (ww.isdog == true) Debug.Log("<<<");
        angle = pictures[0].transform.eulerAngles.z;
        if (

               ww.isdog == true &&
              //  pictures[0].transform.eulerAngles.z == 0 &&
                pictures[0].transform.eulerAngles.z == 0 &&
                pictures[2].transform.eulerAngles.z == 0 &&
                pictures[3].transform.eulerAngles.z == 0 &&
                pictures[4].transform.eulerAngles.z == 0 && 
                pictures[5].transform.eulerAngles.z == 0 &&
                pictures[6].transform.eulerAngles.z == 0 &&
                pictures[7].transform.eulerAngles.z == 0 &&
                pictures[1].transform.eulerAngles.z == 0)
        {
            youwin = true;
           
            showlight.SetActive(true);//雙電流
            showlight2.SetActive(true);//雙電流
            lightup = true;
           

            lightout.SetActive(false);//閃爍光
            place.SetActive(false);//黑白發電室
            afterlight.SetActive(true);//通電後燈開
           Flowchart.BroadcastFungusMessage ( "0000" );

        }
    }
}
//rotation.z