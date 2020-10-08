using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cx : MonoBehaviour
{
    public xray AA;
  
    void Start()
    {
        AA = AA.GetComponent<xray>();
       
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "window")
        {
            AA.StartMove();
          
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
