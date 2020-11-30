using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Knifeclick : MonoBehaviour
{
    // Start is called before the first frame update

    void OnMouseDown() {
        Flowchart.BroadcastFungusMessage ( "呼叫刀子" );
        Debug.Log("0000");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
