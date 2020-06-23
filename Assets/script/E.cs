using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E : MonoBehaviour
{
    //public GameObject Modeobject;
    //public GameObject soundobject;
    public GameObject item1;
    public int itemstate = 0;

    public int Eopen = 0;//設立毀壞狀態
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "player")
        {
           // Instantiate(Modeobject, transform.position, Quaternion.identity);
                Eopen = 1;
              
          
         
        }


        //Instantiate(Modeobject, transform.position, Quaternion.identity);

    }






    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}























